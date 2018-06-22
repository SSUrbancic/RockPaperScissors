using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        //member attributes (HAS A...)

        //gestureArray[0] = Rock, gestureArray[1] = Paper, gestureArray[2] = Scissors, gestureArray[3] = Spock, gestureArray[4] = Lizard// 
        public int[] gestureArray = { 0, 1, 2, 3, 4 };
        public List<int> roundWins = new List<int>();
        public string playerName;

        //Constructor
        public Player()
        {
            DetermineName();
        }





        //DetermineName
        public virtual void DetermineName()
        {
            Console.WriteLine("What is your Name?");
            playerName = Console.ReadLine();
            Console.WriteLine("Players Name is: " + playerName);
        }



        //DetermineGesture

        public virtual int DetermineGesture()
        {
            Console.WriteLine("Choose a gesture: 1- rock, 2 - paper, 3 - scissors, 4 - Spock, 5 - Lizard");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int gesture;

            if (userInput == 1)
            {
                gesture = gestureArray[0];
                Console.WriteLine("Rock");
                return gesture;
            }
            else if (userInput == 2)
            {
                gesture = gestureArray[1];
                Console.WriteLine("Paper");
                return gesture;
            }
            else if (userInput == 3)
            {
                gesture = gestureArray[2];
                Console.WriteLine("Scissors");
                return gesture;
            }
            else if (userInput == 4)
            {
                gesture = gestureArray[3];
                Console.WriteLine("Spock");
                return gesture;
            }
            else if (userInput == 5)
            {
                gesture = gestureArray[4];
                Console.WriteLine("Lizard");
                return gesture;
            }
            else
            {
                Console.WriteLine("Invalid Input, please try again!!!");
                DetermineGesture();
                return 100;
            }









        }
    }
}
