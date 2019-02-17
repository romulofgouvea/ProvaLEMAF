<template>
  <div class="contain">
    <ul class="cards row" v-if="trips.length !== 0 ">
      <li
        class="cards-item rounded col-sm-12 col-md-12 col-lg-12 col-xl-5"
        v-bind:key="trip.trip_id"
        v-for="trip in trips"
        v-on:click="OnClickCard(trip)"
        >
        <CardItem v-bind:trip="trip"/>
      </li>
    </ul>
   <div v-else style="text-align:center;padding: 50px;">
      <h3 >Sorry, no trips found.</h3>
      <h3 >Change the form to find a trip.</h3>
   </div>
  </div>
</template>

<script>
import CardItem from "./item/CardItem";

export default {
  name: "Cards",
  components: {
    CardItem
  },
  props: ["trips"],
  methods: {
    OnClickCard(data) {
      this.$router.push({ name: "Trip", params: { trip: data } });
    }
  }
};
</script>

<style scoped>
.cards {
  list-style: none;
  padding: 0 0 25px 0;
  margin: 0;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
}
.cards-item {
  box-shadow: 0px 1px 10px 0px #c4c4c4;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
  overflow: hidden;
  margin: 0 0 20px 0;
  padding: 0;
  max-height: 140px;
}
.contain {
  width: 100%;
}

@media (min-width: 979px) {
  .cards-item {
    margin: 0 20px 20px 0;
  }
}
</style>