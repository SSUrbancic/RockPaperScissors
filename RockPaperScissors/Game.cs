using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {

        //gestureArray[0] = Rock, gestureArray[1] = Paper, gestureArray[2] = Scissors, gestureArray[3] = Spock, gestureArray[4] = Lizard// 
        public int[] gestureArray = { 0, 1, 2, 3, 4 };
        public int playerOneChoice;
        public int playerTwoChoice;



        //Constructor
        public Game()
        {
            Console.WriteLine(ExecuteRound());
        }

        //method
        public int DetermineRandomGesture()
        {
            int randomSelection = gestureArray[new Random().Next(0, gestureArray.Length)];
            return randomSelection;
        }
        
        public int DetermineGesture()
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
            public string ExecuteRound()
            {
            playerOneChoice = DetermineGesture();
            Console.ReadLine();
            playerTwoChoice = DetermineRandomGesture();
            Console.WriteLine(Console.ReadLine());
            int roundValue = (5 + playerOneChoice - playerTwoChoice) % 5;

            if (roundValue == 1 || roundValue == 3)
            {
                Console.WriteLine("Player One Wins!");
                return Console.ReadLine();
            }
            else if (roundValue == 2 || roundValue == 4)
            {
                Console.WriteLine("Player Two Wins!");
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It's a tie!");
                return Console.ReadLine();
            }

            

            }
    }
    }
