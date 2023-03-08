using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoseKing
{
    internal class Board
    {

        public List<Tile> tiles = new List<Tile>(81);

        public Board() 
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tiles.Add(new Tile(i, j));
                }
                
            }
        }
    }
}
