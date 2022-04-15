using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Oyunda iki oyuncu olarak
             * Her oyuncuda 2 adet zar olacak
             * Oyuncular sırasıyla zar atar
             * Zarlar karşılaştırılır
             * Büyük atan kazanır
             * 
             * Nesneler:
             * 1-Oyun
             * 2-Oyuncu
             * 3-Zar
             * 
             */

            do
            {
                Game game = new Game();
                game.Player1 = new Player { Name = "Onur" };
                game.Player2 = new Player { Name = "Ümit" };
                game.PlayAndTurn();
                game.ShowWinner();
                Console.WriteLine("Do you wanna end the game?");
                

            } while (Console.ReadLine()!="E");
            

            
        }
    }
}
