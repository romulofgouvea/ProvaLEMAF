
<template >
  <div>
    <Header v-bind:title="title"/>
    <CardHeader v-on:search-trips="searchTrips"/>
    <Cards v-bind:trips="trips"/>
  </div>
</template>

<script>
import Header from "../../components/layout/header/Header";
import CardHeader from "../../components/layout/header/nav/CardHeader";
import Cards from "../../components/card/Cards";

import axios from "axios";
axios.defaults.withCredentials = true;

export default {
  name: "Home",
  components: {
    Header,
    CardHeader,
    Cards
  },
  data() {
    return {
      title: "my trips",
      BASE_URL: "http://localhost:64154/api",
      temp: [],
      trips: [],
      cities: []
    };
  },
  methods: {
    getAllTrips() {
      return axios
        .get(this.BASE_URL + "/Trips", { withCredentials: true })
        .then(res => (this.trips = this.temp = res.data))
        .catch(err => console.log("Error: " + err));
    },
    getAllCities() {
      return axios
        .get(this.BASE_URL + "/City")
        .then(resCity => (this.cities = resCity.data))
        .catch(err => console.log("Error: " + err));
    },
    getTripsByCity(searchTrips) {
      return axios
        .get(
          this.BASE_URL +
            "/Trips?trip_city=" +
            searchTrips.city_id +
            "&trip_date=" +
            searchTrips.city_date
        )
        .then(resTrips => {
          let arrayTemp = [];
          resTrips.data.filter(filTrips => {
            if (
              filTrips.trip_cost <= searchTrips.city_cost &&
              filTrips.trip_guest === searchTrips.city_guest &&
              filTrips.trip_class === searchTrips.city_class
            ) {
              arrayTemp.push(filTrips);
            }
          });

          return (this.trips = arrayTemp);
        })
        .catch(err => console.log("Error: " + err));
    },
    searchTrips(searchTrips) {
      if (searchTrips.city_name === "") {
        this.trips = this.temp;
      }

      this.cities.filter(filCity => {
        if ( this.removeAcento(searchTrips.city_name.toLowerCase()) === this.removeAcento(filCity.city_name.toLowerCase()) ) {
          searchTrips = Object.assign(
            { city_id: filCity.city_id },
            searchTrips
          );
          return this.getTripsByCity(searchTrips);
        }
      });
    },
    removeAcento(text) {
      text = text.toLowerCase();
      text = text.replace(new RegExp("[ÁÀÂÃ]", "gi"), "a");
      text = text.replace(new RegExp("[ÉÈÊ]", "gi"), "e");
      text = text.replace(new RegExp("[ÍÌÎ]", "gi"), "i");
      text = text.replace(new RegExp("[ÓÒÔÕ]", "gi"), "o");
      text = text.replace(new RegExp("[ÚÙÛ]", "gi"), "u");
      text = text.replace(new RegExp("[Ç]", "gi"), "c");
      return text;
    }
  },
  created() {
    this.getAllTrips();
    this.getAllCities();
  }
};
</script>


<style scoped></style>