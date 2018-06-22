using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {

        public override void DetermineName()
        {
            playerName = "Computer";
            Console.WriteLine("Player Two: " + playerName);
        }


        public override int DetermineGesture()
        {
            int randomSelection = gestureArray[new Random().Next(0, gestureArray.Length)];
            Console.WriteLine("Computer chose: " + randomSelection);
            return randomSelection;
        }


    }
}
