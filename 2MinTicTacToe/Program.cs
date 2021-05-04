using System;

namespace _2MinTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       
    }

    public class Board
    {
        public Spot[] Spots { get;  }
        public Board() {
            Spots = new Spot[9];
        }

        public bool IsValidMove() { return false;  }

    }

    public class Spot
    {
        public int Row{ get; }
        public int Column { get; }

        public Spot(int row, int column)
        {
            Row= row;
            Column = column;
        }
    }

}
