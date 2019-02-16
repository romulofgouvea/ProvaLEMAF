<style src="./style.css" scoped></style>
<template src="./template.html"></template>

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
      // router.push({ name: 'Trip', params: { userId: '123' } })
      console.log("Clicked");
    }
  }
};
</script>
