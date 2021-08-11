import command from '@/common/Command'

export default class GameCreateCommand extends command {
    constructor(id){
        super()
        this.id = id
        this.title = ""
        this.platform = ""
        this.price = 0
        this.description = ""
        this.released = "" 
        this.category = []
    }

    formatApiUrl(){
        return 'Game/'
    }
}