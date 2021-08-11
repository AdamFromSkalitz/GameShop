import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import GameDetails from '@/components/GameDetails'
import GameCreate from '@/components/GameCreate'

Vue.use(Router)


export default new Router({
    routes: [{path: '/', name:'Home', component: Home},
              {path: '/details/:id', name:'GameDetails', component: GameDetails},
              {path: '/add/', name:'GameCreate', component: GameCreate}]
})