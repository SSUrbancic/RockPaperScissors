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
        
        
        
        
        //Constructor
        public Game()
        {
            DetermineRandomGesture();
            DetermineGesture();
            Console.WriteLine(DetermineGesture());
        }

        //method
        public string DetermineRandomGesture()
        {
            string randomSelection = gestureArray[new Random().Next(0, gestureArray.Length)];
            return randomSelection;
        }
        
        public string DetermineGesture()
        {
            Console.WriteLine("Choose a gesture: 1- rock, 2 - paper, 3 - scissors, 4 - Lizard, 5 - Spock");
            string userInput = Console.ReadLine();
            string gesture;

            if (userInput == "1")
            {
                gesture = gestureArray[0];
                return gesture;
            }
            else if (userInput == "2")
            {
                gesture = gestureArray[1];
                return gesture;
            }
            else if (userInput == "3")
            {
                gesture = gestureArray[2];
                return gesture;
            }
            else if (userInput == "4")
            {
                gesture = gestureArray[3];
                return gesture;
            }
            else if (userInput == "5")
            {
                gesture = gestureArray[4];
                return gesture;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                DetermineGesture();
                return null;
            }






        }
            public void GameFunction()
            {


            }




        }
    }
