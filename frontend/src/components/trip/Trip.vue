<style src="./style.css" scoped></style>
<template src="./template.html"></template>

<script>
import Header from "../layout/header/Header";
import StarRating from "vue-star-rating";

export default {
  name: "Trip",
  components: {
    Header,
    StarRating
  },
  data(){
    return{
      title:''
    }
  },
  props: ["trip"],
  methods: {
    OnClickIcon(data) {
      this.$router.push({ name: 'Home' })
    }
  }
};
</script>
