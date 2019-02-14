<template>
  <div class="card card-header">
    <form @submit="searchTrips">
      <input type="text" v-model="city_name" name="city_name" placeholder="Dubai,UAE">
      <!-- <input type="date" v-model="city_date" name="city_date"> -->
      
      <datepicker v-model="city_date" name="city_date"></datepicker>

      <button class="btn btn-default" type="button" title="Toggle" data-toggle>
        <i class="fa fa-calendar">
          <span aria-hidden="true" class="sr-only">Toggle</span>
        </i>
      </button>
      
      <select v-model="city_guest">
        <option
          v-for="option in optionsGuest"
          v-bind:key="option.value"
          v-bind:value="option.value"
        >{{ option.text }}</option>
      </select>
      <select v-model="city_class">
        <option
          v-for="option in optionsClass"
          v-bind:key="option.value"
          v-bind:value="option.value"
        >{{ option.text }}</option>
      </select>
      
      <input type="number" v-model="city_cost" name="city_cost" placeholder="800">
      <input type="submit" value="Submit">
    </form>
  </div>
</template>

<script>
import Datepicker from "vuejs-datepicker";

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
      city_cost: 0
    };
  },
  methods: {
    searchTrips(e) {
      e.preventDefault();
      const newSearch = {
        city_name: this.city_name,
        city_date: this.city_date,
        city_cost: this.city_cost,
        city_guest: parseInt(this.city_guest),
        city_class: parseInt(this.city_class)
      };
      this.$emit("search-trips", newSearch);
    }
  }
};
</script>

<style>
.card-header {
  border: 1px #eee solid;
  border-radius: 10px;

  color: #2eafff !important;
  width: 100%;
  z-index: 99;
  padding: 10px;
  background-color: white;

  -webkit-box-shadow: 0px 0px 2px 1px rgba(238, 238, 238, 1);
  -moz-box-shadow: 0px 0px 2px 1px rgba(238, 238, 238, 1);
  box-shadow: 0px 0px 2px 1px rgba(238, 238, 238, 1);
}

.flex-container {
  padding: 0;
  margin: 0;
  list-style: none;
  display: flex;
  align-items: center;
  justify-content: center;
}
.flex-item {
  font-weight: bold;
  font-size: 1.5em;
  text-align: center;
}
</style>
