import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '../pages/HomePage.vue'
import ServicesPage from '../pages/ServicesPage.vue'
import BookingPage from '../pages/BookingPage.vue'
import ConfirmationPage from '../pages/ConfirmationPage.vue'
import ContactPage from '../pages/ContactPage.vue'

const routes = [
  { path: '/', name: 'Home', component: HomePage },
  { path: '/services', name: 'Services', component: ServicesPage },
  { path: '/booking', name: 'BookingPage', component: BookingPage },
  { path: '/confirmation', name: 'Confirmation', component: ConfirmationPage },
  { path: '/contact', name: 'Contact', component: ContactPage },

]


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL), routes
  // routes: [
  //   {
  //     path: '/',
  //     name: 'home',
  //     component: HomeView,
  //   },
  //   {
  //     path: '/about',
  //     name: 'about',
  //     // route level code-splitting
  //     // this generates a separate chunk (About.[hash].js) for this route
  //     // which is lazy-loaded when the route is visited.
  //     component: () => import('../views/AboutView.vue'),
  //   },
  // ],
})

export default router
