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
        <h4 class="card-name">teeeeeessssteeee  sdhgasjdasjgjds dsadasjdjjjjdaseoooooooooo dsadasjdjjjjdaseoooooooooo{{trip.trip_name}}</h4>
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
h4 {
    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;
    max-width: 75ch;
    max-width: 200px;
}

img {
  max-width: 150px;
}
.card-content {
  flex-grow: 1;
}
.card-rate {
  padding-top: 16px;
}
.card-name{
  font-size: 0.675em;
  margin: 0;
}
.card-desc{
  font-size: 0.475em;
  color: gray
}
.card-cost {
  color: #2acfff;
  font-size: 1em;
  float: left;
}
</style>
