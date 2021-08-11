import GameDetails from '@/components/GameDetails'
import Game from '@/components/GameDto'
import GameQuery from '@/components/GameViewQuery'

describe('When GameDetails is created'), () => {
    it('executes query', () => {
        var game = new Game();
        var mockQuery = Mock<GameQuery>
        mockQuery.expects('execute').once.returns(actual)

        vm.init()

        return actual.should.equal(game)
    })
}