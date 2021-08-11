<template>
    <div>
    <b-row>
      <b-col cols="4"></b-col>
         <b-col cols="4">
        <b-list-group>
            <b-list-group-item href="#" v-for="game in games" :key="game.id"> 
                <router-link id="router-link" :to="'/details/'+game.id">{{game.title}}</router-link>
            </b-list-group-item>
        </b-list-group>
          </b-col>
        <b-col cols="4"></b-col>
    </b-row>
    </div>
</template>
<script>
import GamesQuery from './GamesQuery'

export default {
    name: 'Home',
    beforeMount(){
        return this.init()

    },
    methods:{
        init(){
            return this.query.execute().then((gameResponse) => {
                this.games = gameResponse
            })
        }
    },
    data (){
        return {
            query: new GamesQuery(),
            games: []
        }
    }

}
</script>

<style scoped>
#router-link{
  color: inherit;
  text-decoration: none;
  display: block;
  width: 100%;
} 
</style>