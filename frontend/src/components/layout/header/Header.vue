<template>
  <header class="header">
    <h1>{{title}}</h1>
  </header>
</template>

<script>
export default {
  name: "Header",
  props:['title']
};
</script>

<style scoped>
.header {
  background-image: linear-gradient(to right, #30aaff, #2acfff);
  color: #fff;
  text-align: center;
  padding: 10px;
  padding-bottom: 60px;
}
.header a {
  color: #fff;
  padding-right: 5px;
  text-decoration: none;
}
</style>