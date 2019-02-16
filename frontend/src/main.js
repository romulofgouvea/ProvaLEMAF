import Vue from 'vue';
import App from './App.vue';
import router from './router'

// Importing CSS GLOBAL
import './style.css';
// import './src/assets/styles/css/bootstrap.min.css';
// require('bootstrap');

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
  router,
}).$mount('#app')
