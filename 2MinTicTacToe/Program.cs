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
        public string[] Spots { get;  }
        public Board() {
            Spots = new string[0];
        }
    }

    public class Spot
    {
        public int Row{ get; }

        public Spot(int row)
        {
            Row= row;
        }
    }

}
