<template>
  <div class="no-gutters v-align">
    <div class="card-image">
      <!-- <img src="//placehold.it/150" alt> -->
      <img class="rounded-left" v-bind:src="trip.trip_url_image" alt>
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
      <h4 class="card-cost">{{trip.trip_cost}},00 {{trip.trip_coin}}</h4>
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
  }
};
</script>

<style scoped>
.v-align {
  vertical-align: middle;
}
h4 {
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
  max-width: 75ch;
  max-width: 200px;
}
p {
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
  max-width: 100ch;
}

img {
  max-width: 100%;
  width: 140px;
  height: 140px;
  margin: auto;
  display: block;
  float: left;
}
.card-image {
  max-width: 40%;
}
.card-content {
  display: block;
  overflow: hidden;
}
.card-name {
  font-size: 14px;
  color: #355c6e;
  margin: 0;
  padding: 0 0 3px 0;
}
.card-rate {
  padding: 10px 0 3px 0;
}
.card-desc {
  font-size: 10px;
  color: #abc0cc;
}
.card-cost {
  float: right;
  display: block;
  font-size: 18px;
  color: #3bc8f1;
}

/* Large desktop */
@media (min-width: 1200px) {
}

@media (min-width: 979px) {
  .card-name {
    font-size: 20px;
  }
  .card-desc {
    font-size: 14px;
  }
}

/* Portrait tablet to landscape and desktop */
@media (min-width: 768px) and (max-width: 979px) {
}

/* Landscape phone to portrait tablet */
@media (min-width: 767px) {
}

/* Landscape phones and down */
@media (max-width: 480px) {
}
</style>