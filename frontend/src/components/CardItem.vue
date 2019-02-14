<template>
    <div class="card-item" v-on:click="OnClickCard($event)">
        <span class="card-name">{{trip.trip_name}} {{trip.trip_city}}</span>
        <span class="card-desc">{{trip.trip_desc}}</span>
        <span class="card-cost">{{trip.trip_cost}}</span>
        <span class="card-cost">{{trip.trip_coin}}</span>
    </div>
</template>

<script>
export default {
    name:"CardItem",
    props:["trip"],
    methods:{
        OnClickCard: function(event) {
            console.log("Clicked");
        }
    }
}
</script>

<style scoped>
    .card-item{
        border: 1px #eee solid;
        border-radius: 10px;
        margin: 16px;
        -webkit-box-shadow: 0px 0px 2px 1px rgba(238,238,238,1);
        -moz-box-shadow: 0px 0px 2px 1px rgba(238,238,238,1);
        box-shadow: 0px 0px 2px 1px rgba(238,238,238,1);
    }
    .card-rate{
        padding-top: 16px;
        padding-bottom: 8px;
    }
    .card-name{
        color: #8D93A2;
        font-size: 1.2em;
        font-weight: bold;
    }
    .card-desc{
        color: #D1D5DE;
        font-size: 0.875;
    }
    .card-cost{
        color: #30AAFF;
        font-size: 1em;
    }

</style>
