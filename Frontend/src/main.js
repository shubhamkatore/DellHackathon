import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./registerServiceWorker";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import buefy from "buefy";
import axios from "axios";

Vue.$http = axios;
Vue.component("font-awesome-icon", FontAwesomeIcon);
Vue.use(buefy);
Vue.config.productionTip = false;

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
