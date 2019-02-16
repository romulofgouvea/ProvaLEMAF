
<template src="./template.html"></template>

<script>
import Header from "../layout/header/Header";
import CardHeader from "../layout/nav/CardHeader";
import Cards from "../card/Cards";

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
      BASE_URL: "http://localhost:3000", //Teste
      // BASE_URL:"http://localhost:64154/api",
      trips: []
    };
  },
  methods: {
    searchTrips(searchTrips) {
      axios
        .get(this.BASE_URL + "/City")
        .then(resCity =>
          resCity.data.filter(filCity => {
            if (searchTrips.city_name === filCity.city_name) {
              //console.log("Cidade: ", filCity.city_name, filCity.city_id);
              return axios
                .get(this.BASE_URL + "/Trips?trip_city=" + filCity.city_id)
                .then(resTrips => {
                  let arrayTemp = [];
                  resTrips.data.filter(filTrips => {
                    if (
                      filTrips.trip_cost <= searchTrips.city_cost &&
                      filTrips.trip_guest <= searchTrips.city_guest &&
                      filTrips.trip_class === searchTrips.city_class
                    ) {
                      arrayTemp.push(filTrips);
                    }
                  });
                  return (this.trips = arrayTemp);
                })
                .catch(err => console.log("Error: " + err));
            }
          })
        )
        .catch(err => console.log("Error: " + err));
    }
  },
  created() {
    axios
      .get(this.BASE_URL + "/Trips", { withCredentials: true })
      .then(res => (this.trips = res.data))
      .catch(err => console.log("Error: " + err));
  }
};
</script>


<style scoped></style>