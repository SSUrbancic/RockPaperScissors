using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        string[] gestureArray = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public Game()
        {
            DetermineRandomGesture();
            Console.WriteLine(DetermineRandomGesture());

        }

        //method
        public string DetermineRandomGesture()
        {
            string randomSelection = gestureArray[new Random().Next(0, gestureArray.Length)];
            return randomSelection;
        }

            public void GameFunction()
            {
                Console.WriteLine("Choose a gesture: 1- rock, 2 - paper, 3 - scissors, 4 - spock, 5 - lizard");
                string gesture = Console.ReadLine();

                if (gesture == "1")
                {

                }
            }




        }
    }
