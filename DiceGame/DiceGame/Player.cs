using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Player
    {
        public string Name { get; set; }

        public Dice Dice1 { get; set; }

        public Dice Dice2 { get; set; }

        public Player()
        {
            Dice1 = new Dice();
            Dice2 = new Dice();
        }

        private int numberOfDice1 = 0;
        private int numberOfDice2 = 0;
        public void Play()
        {
             Dice1.ThrowDice();
             Dice2.ThrowDice();
             numberOfDice1 = Dice1.Number;
             numberOfDice2 = Dice2.Number;
             Console.WriteLine($"Number of Dices {numberOfDice1} and {numberOfDice2}");

        }

        public int Score { get { return numberOfDice1 + numberOfDice2; } }
    }
}
