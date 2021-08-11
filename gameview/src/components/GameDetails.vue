<template>
<div>
    <h1>{{game.title}}</h1>
    <b-row>
        <b-col cols="4"></b-col>
        <b-col cols="4">
            <b-card>
                <b-card-text>
                    {{game.description}}
                </b-card-text>
                <b-card-text>
                    Release Date: {{game.released}}
                </b-card-text>
                <b-card-text>
                    Only for {{game.platform}}
                </b-card-text>
                <b-card-text>
                    £{{game.price}}
                </b-card-text>
                <b-card-text v-for="c in game.category" :key="c">
                    {{c}}
                </b-card-text>
            </b-card>
        </b-col>
        <b-col cols="4"></b-col>
    </b-row>
</div>
</template>

<script>
import GameViewQuery from './GameViewQuery'
import Game from './GameDto'

export default {
    name:"GameDetails",
    beforeMount(){
        return this.init()
    },
    methods:{
        init(){
            this.query.id = this.id;
            return this.query.execute().then((gameResponse) => {
                this.game = gameResponse
            })
        }
    },
    data(){
        return {
            id: this.$route.params.id,
            query: new GameViewQuery(),
            game: new Game()
        }
    }
}
</script>