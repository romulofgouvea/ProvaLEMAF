<template>
  <div class v-on:click="OnClickCard($event)">
    <div class="row no-gutters">
      <div class="card-image">
        <img src="//placehold.it/150" alt>
        <!-- <img src="{{trip.trip_url_image}}" alt> -->
      </div>
      <div class="card-content px-2 ml-2 mr-2">
        <div class="card-rate">
          <star-rating
            v-bind:show-rating="false"
            v-bind:star-size="10"
            v-bind:increment="0.5"
            :rating="trip.trip_rate"
          ></star-rating>
        </div>
        <h4 class="card-name">{{trip.trip_name}}</h4>
        <p class="card-desc">{{trip.trip_desc}}</p>
        <h4 class="card-cost">{{trip.trip_cost}} {{trip.trip_coin}}</h4>
      </div>
    </div>
  </div>
</template>

<script>
import StarRating from "vue-star-rating";

export default {
  name: "CardItem",
  props: ["trip"],
  components: {
    StarRating
  },
  methods: {
    OnClickCard: function(event) {
      console.log("Clicked");
    }
  }
};
</script>

<style scoped>
img {
  max-width: 150px;
}
.card-content {
  flex-grow: 1;
}
.card-rate {
  padding-top: 16px;
}
.card-cost {
  float: left;
}
</style>
