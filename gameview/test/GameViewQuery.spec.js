import GameQuery from '@/components/GameViewQuery'
import sinon from 'sinon'

describe('DebtorDetailsIdentityQuery', () => {
    var query, sandbox

    beforeEach(() => {
        query = new GameQuery()
        query.id = 1000
        sandbox = sinon.sandbox.create()
    })

    afterEach(() => {
        sandbox.verifyAndRestore()
    })

    describe('URL formatting',() => {
        it('Returns the appropriate URL for the required API endpoint', () => {
            var expected ='Game/'
            var actualURL = query.formatApiUrl()
            actualURL.should.equal(expected)
        })
    })
})
