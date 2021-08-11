import Query from '@/common/Query'

export default class extends Query
{
    formatApiUrl(){
        return 'Game/'
    }

    newResult = () => {return []}
}