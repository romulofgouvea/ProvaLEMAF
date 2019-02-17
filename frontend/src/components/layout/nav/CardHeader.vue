<style src="./style.css" scoped></style>
<template src="./template.html"></template>

<script>
import Datepicker from "vuejs-datepicker";
import moment from "moment";

export default {
  name: "CardHeader",
  components: {
    Datepicker
  },
  data() {
    return {
      city_guest: "1",
      city_class: "1",
      optionsGuest: [
        { text: "1 Guest", value: "1" },
        { text: "2 Guest", value: "2" },
        { text: "3 Guest", value: "3" },
        { text: "4 Guest", value: "4" },
        { text: "5 Guest", value: "5" },
        { text: "6 Guest", value: "6" },
        { text: "7 Guest", value: "7" },
        { text: "8 Guest", value: "8" }
      ],
      optionsClass: [
        { text: "First Class", value: "1" },
        { text: "Executive", value: "2" },
        { text: "Economic", value: "3" }
      ],
      city_name: "",
      city_date: new Date(),
      city_cost: 0,
      disabledDates: {
        to: new Date()
      }
    };
  },
  methods: {
    formChange(e) {
      e.preventDefault();

      const newSearch = {
        city_name: this.city_name,
        city_date: moment(new Date()).format("YYYY/MM/DD"),
        city_cost: this.city_cost,
        city_guest: parseInt(this.city_guest),
        city_class: parseInt(this.city_class)
      };
      this.$emit("search-trips", newSearch);
      console.log("emit");
    }
  }
};
</script>

