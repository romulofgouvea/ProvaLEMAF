import Vue from 'vue';
import App from './App.vue';
import router from './router'

// Importing CSS GLOBAL
import './style.css';

Vue.use(require('vue-moment'));

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
  router,
}).$mount('#app')
