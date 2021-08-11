import QueryById from '@/common/QueryById'
import GameDto from './GameDto'

export default class extends QueryById
{
    formatApiUrl(){
        return 'Game/' + this.id
    }

    newResult = () => {return new GameDto()}
}