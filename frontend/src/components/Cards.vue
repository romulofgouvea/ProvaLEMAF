<template>
    <div>
        <div v-bind:key="trip.trip_id" v-for="trip in trips">
           <CardItem v-bind:trip="trip"/>
        </div>
    </div>
</template>

<script>
import CardItem from './CardItem';

export default {
    name:"Cards",
    components:{
        CardItem
    },
    props:["trips"]
}
</script>

<style scoped>

</style>
