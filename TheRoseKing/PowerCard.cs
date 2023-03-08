using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoseKing
{
    public enum Direction { Left, Right, Up, Down };
    internal class PowerCard
    {
        public static List<PowerCard> powerCards= new List<PowerCard>();

        int distance;
        Direction direction;

        static Random r = new Random();
        

        public PowerCard(Direction direction, int distance) {

            this.distance = distance;
            this.direction = direction;
        
        }

        public static void createPowerCards()
        {
            for (int i = 0; i < 24; i++)
            {
                int dist = r.Next(1,4);
                Direction d = (Direction) r.Next(0, 4);

                //Console.WriteLine($"{d}, {dist}");

                PowerCard p = new PowerCard(d, dist);
                powerCards.Add(p);
            }
        }


    }
}
