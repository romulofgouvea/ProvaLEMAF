<template>
  <div id="app">
    <Header/>
    <CardHeader v-on:search-trips="searchTrips"/>
    <Cards v-bind:trips="trips"/>
  </div>
</template>

<script>
import Header from "./components/layout/Header";
import CardHeader from "./components/layout/CardHeader";
import Cards from "./components/Cards";

import axios from "axios";
axios.defaults.withCredentials = true;

export default {
  name: "app",
  components: {
    Header,
    CardHeader,
    Cards
  },
  data() {
    return {
      BASE_URL:"http://localhost:3000",
      // BASE_URL:"http://localhost:64154/api",
      trips: []
    };
  },
  methods: {
    searchTrips(searchTrips) {
      //http://localhost/Trips/City/{id da cidade}
      //http://localhost/Trips/GetTripsByCity?id={id da cidade}
      // console.log(searchTrips)
      axios
        .get(this.BASE_URL+"/City")
        .then(resCity => resCity.data.filter( filCity => {
            if(searchTrips.city_name === filCity.city_name){
              console.log("Cidade: ", filCity.city_name,filCity.city_id)
              return axios
                .get(this.BASE_URL+"/Trips?trip_city="+filCity.city_id)
                .then(resTrips => {
                  let arrayTemp = []
                  resTrips.data.filter( filTrips => {
                    if(filTrips.trip_cost <= searchTrips.city_cost &&
                      filTrips.trip_guest <= searchTrips.city_guest &&
                      filTrips.trip_class === searchTrips.city_class){
                      arrayTemp.push(filTrips);
                    }
                  })
                  return (this.trips = arrayTemp)
                  })
                .catch(err => console.log("Error: " + err));
            }
        }) )
        .catch(err => console.log("Error: " + err));
    }
  },
  created() {
    axios
      .get(this.BASE_URL+"/Trips",{withCredentials:true})
      .then(res => (this.trips = res.data))
      .catch(err => console.log("Error: " + err));
  }
};
</script>

<style>

/* iniital config */
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  font-family: Arial, Helvetica, sans-serif;
  line-height: 1.4;
}

.contain{
    width: 100%;
    padding-right: 15px;
    padding-left: 15px;
    margin-right: auto;
    margin-left: auto;
}

/* props config */
input, input::placeholder, select {
  border: none;
  color: #2acfff !important;
}

/* make solution */
.none {
  padding-right: 0 !important;
  border: none;
  text-decoration: none;
  color: #2acfff !important;
}

</style>
