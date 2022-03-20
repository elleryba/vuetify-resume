import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import AboutMe from '@/views/AboutMe.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Home',
    component: AboutMe,
  }
]

const router = new VueRouter({
  routes,
})

export default router
