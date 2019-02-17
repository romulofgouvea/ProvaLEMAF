
<template>
  <div>
    <Header v-bind:title="title"/>

    <div class="contain fFooter">
      <div class="card card-sobre">
        <div class="card-body">
          <div style="display:flex">
            <i class="material-icons" v-on:click="OnClickIcon()">arrow_back</i>
            <h2 class="card-name">{{trip.trip_name}}</h2>
          </div>
        </div>
      </div>

      <div class="card-image">
        <!-- <img src="//placehold.it/150" alt> -->
        <img class="rounded-left" v-bind:src="trip.trip_url_image" alt>
      </div>
      <div class="card-content px-2 ml-2 mr-2">
        <div class="card-rate">
          <star-rating
            v-bind:show-rating="false"
            v-bind:star-size="20"
            v-bind:increment="0.5"
            :rating="trip.trip_rate"
          ></star-rating>
        </div>
        <p class="card-desc">{{trip.trip_desc}}</p>
      </div>
    </div>
    <!-- <h4 class="card-cost">  {{trip.trip_cost}},00 {{trip.trip_coin}} </h4> -->
    <div class="footer fixed-bottom">{{trip.trip_cost}},00 {{trip.trip_coin}}</div>
  </div>
</template>

<script>
import Header from "../../components/layout/header/Header";
import StarRating from "vue-star-rating";

export default {
  name: "Trip",
  components: {
    Header,
    StarRating
  },
  data() {
    return {
      title: ""
    };
  },
  props: ["trip"],
  methods: {
    OnClickIcon(data) {
      this.$router.push({ name: "Home" });
    }
  }
};
</script>


<style scoped>
img {
  margin: auto;
  display: block;
  float: left;
  max-width: 100%;
  padding: 0 15px;
}
i {
  font-size: 30px;
}

.card-sobre {
  margin-top: -60px;
  z-index: 99;
  margin-bottom: 16px;
  box-shadow: 0px 1px 10px 0px #dddddd;
}

.card-content {
  display: block;
  overflow: hidden;
}
.card-name {
  font-size: 20px;
  padding: 3px 0 0 20px;
  margin: 0;
  color: #355c6e;
  word-wrap: break-word;
}
.card-rate {
  padding: 10px 0;
}
.card-desc {
  font-size: 20px;
  color: #abc0cc;
}
.card-cost {
  float: right;
  display: block;
  color: #3bc8f1;
  font-size: 18px;
}

.footer {
  position: fixed;
  color: white;
  text-align: center;
  text-align: center;
  font-weight: bold;
  left: 0;
  bottom: 0;
  width: 100%;
  padding: 10px;
  font-size: 20px;
  background-image: linear-gradient(to right, #30aaff, #2acfff);
}

.fFooter {
  margin: 0 0 50px 0px;
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
@media (min-width: 979px) {
  img {
    max-width: 30%;
  }
}

/* Landscape phone to portrait tablet */
@media (min-width: 767px) {
}

/* Landscape phones and down */
@media (max-width: 480px) {
}
</style>