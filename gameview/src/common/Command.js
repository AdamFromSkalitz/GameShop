import axios from 'axios'

export default class Command{
    constructor(){
    }

    formatApiUrl(){
        return ''
    }

    // onQuerySuccess(response){
    //     console.log("Log Query Success");
    //     return response.data
    // }

    // onQueryFailure(error){
    //     console.log("Log Query Failure");
    //     return error
    // }

    execute(){
        return axios.post("https:localhost:5001/" + this.formatApiUrl(), this.game).then(this.onQuerySuccess, this.onQueryFailure)
    }
}