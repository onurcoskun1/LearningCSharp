using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
        }

        public void PlayAndTurn()
        {
            Player1.Play();
            Player2.Play();


        }

        public void ShowWinner()
        {
            if (Player1.Score > Player2.Score)
            {
                Console.WriteLine($"Total Score : {Player1.Score}! {Player1.Name} WIN!");
            }
            else if(Player1.Score < Player2.Score)
            {
                Console.WriteLine($"Total Score : {Player2.Score}! {Player2.Name} WIN!");
            }
            else
            {

            }
        }
    }
}
