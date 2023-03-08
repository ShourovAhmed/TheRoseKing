using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheRoseKing
{
    internal class Tile
    {
        int x;
        int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
