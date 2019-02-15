<template>
  <div class="contain">
    <ul class="cards">
      <li class="cards-item rounded border border-1 mb-3 mr-3" v-bind:key="trip.trip_id" v-for="trip in trips">
        <CardItem v-bind:trip="trip"/>
      </li>
    </ul>
  </div>
</template>

<script>
import CardItem from "./CardItem";

export default {
  name: "Cards",
  components: {
    CardItem
  },
  props: ["trips"]
};
</script>

<style scoped>
.cards {
  list-style: none;
  margin: 0;
  padding: 0;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-wrap: wrap;
  flex-wrap: wrap;
  flex-direction: row;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}

.cards-item {
  flex-basis: auto;
  flex-grow: 1;
  display: flex;
}

@media (max-width: 979px) {
  .cards-item {
    flex-direction: column;
  }
}
</style>
