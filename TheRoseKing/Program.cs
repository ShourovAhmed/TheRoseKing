namespace TheRoseKing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PowerCard.createPowerCards();

            Board b = new Board();

            foreach (var tile in b.tiles)
            {
                //Console.WriteLine($"{tile.x} , {tile.y}");
                Console.WriteLine(tile);
            }
        }


    }
}