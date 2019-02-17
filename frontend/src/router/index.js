import Vue from 'vue';
import Router from 'vue-router';
import Trip from '../pages/trip/Trip';
import Home from '../pages/home/Home';

Vue.use(Router);

const routes = [
  { path: '/trip', name: 'Trip', component: Trip, props: true },
  { path: '/', name: 'Home', component: Home }
]

export default new Router({ routes, mode: 'history' });