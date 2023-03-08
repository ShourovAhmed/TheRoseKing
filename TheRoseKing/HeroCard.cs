using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoseKing
{
    internal class HeroCard
    {

        public static List<HeroCard> heroCards = new List<HeroCard>(8);

        public static void createHeroCards()
        {
            for (int i = 0; i < heroCards.Count; i++)
            {
                heroCards.Add(new HeroCard());
            }
        }
    }
}
