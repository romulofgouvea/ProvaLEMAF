<style src="./style.css" scoped></style>
<template src="./template.html"></template>

<script>
import Header from "../layout/header/Header";
export default {
  name: "Trip",
  components: {
    Header
  },
  props: ["trip"],
  methods: {
    OnClickIcon(data) {
      this.$router.push({ name: 'Home' })
    }
  }
};
</script>
