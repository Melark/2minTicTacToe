using System;
using Xunit;
using _2MinTicTacToe;

namespace _2MinTicTacToeTests
{
    public class BoardTests
    {

        [Fact]
        public void Board_SpotsAreNotNull() {
            var board = new Board();
            Assert.False(board.Spots == null);
        }

        [Fact]
        public void SpotHasARow()
        {
            var spot = new Spot(1);
            Assert.True(spot.Row == 1);
        }
    }
}
