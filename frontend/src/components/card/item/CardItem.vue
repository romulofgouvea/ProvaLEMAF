<style src="./style.css" scoped></style>
<template src="./template.html"></template>

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
