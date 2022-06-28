import Vue from 'vue'
import LoginComponent from './login.vue';


import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'

Vue.use(BootstrapVue)
Vue.use(IconsPlugin)

new Vue({
    el: "#app",
    components: {
        LoginComponent
    }
})