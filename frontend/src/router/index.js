import Vue from 'vue';
import Router from 'vue-router';
import Trip from '../components/trip/Trip';
import Home from '../components/home/Home';

Vue.use(Router);

const routes = [
  { path: '/trip', name: 'Trip', component: Trip },
  { path: '/', name: 'Home', component: Home }
]

export default new Router({ routes, mode: 'history' });