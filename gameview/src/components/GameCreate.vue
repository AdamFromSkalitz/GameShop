<template>
<div>
    <h1>{{game.title}}</h1>
    <b-row>
        <b-col cols="4"></b-col>
        <b-col cols="4">
            <b-form-group
                id="input-group-1"
                label="Game title:"
                label-for="input-1"
            >
                <b-form-input
                id="input-1"
                type="title"
                placeholder="Enter game title"
                required
                ></b-form-input>
            </b-form-group>
        </b-col>
        <b-col cols="4"></b-col>
    </b-row>
</div>
</template>

<script>
import CreateCommand from './GameCreateCommand'
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
            command: new CreateCommand(),
            game: new Game()
        }
    }
}
</script>