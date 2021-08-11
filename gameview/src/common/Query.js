import axios from 'axios'

export default class Query{
    constructor(){
    }

    formatApiUrl(){
        return ''
    }

    onQuerySuccess(response){
        console.log("Log Query Success");
        return response.data
    }

    onQueryFailure(error){
        console.log("Log Query Failure");
        return error
    }

    execute(){
        return axios.get("https:localhost:5001/" + this.formatApiUrl()).then(this.onQuerySuccess, this.onQueryFailure)
    }
}