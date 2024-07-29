using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "The Legend of Zelda",
                "Assetto Corsa",
                "GTA 5",
                "Sea of Thieves",
                "Halo: Reach",
                "Cyberpunk 2077",
                "Baldur's Gate 3",
                "Elden Ring"
            };

            List<string> gamesOrder = videoGames.OrderBy(game => game.Length).ToList();
            
            Console.WriteLine("Ordered list by title length");
            foreach (var game in gamesOrder)
            {
                Console.WriteLine(game);
            }
        }
    }
}
