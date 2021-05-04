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
        public void Board_Has9Spots()
        {
            var board = new Board();
            Assert.True(board.Spots.Length == 9);
        }

        [Fact]
        public void SpotHasARow()
        {
            var spot = new Spot(1, 0);
            Assert.True(spot.Row == 1);
        }

        [Fact]
        public void SpotHasAColumn()
        {
            var spot = new Spot(0, 1);
            Assert.True(spot.Column == 1);
        }
    }
}
