<style src="./style.css" scoped></style>
<template src="./template.html"></template>

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
      this.$router.push({ name: 'Trip', params: { trip: data } })
    }
  }
};
</script>
