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
        Player playerOne;
        Player playerTwo;
        bool winner = false;




        //Constructor
        public Game()
        {
            DeterminePlayers();
            while (winner == false)
            {
                TrackWinsPerPlayer();
                DetermineWinner();
            }
        }
        //method

        

        public bool DetermineGameType()
        {
            bool singlePlayerGameMode;
            Console.WriteLine("Select Game mode: press 1 for single player or press 2 for multi player.");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                singlePlayerGameMode = true;
                return singlePlayerGameMode;
            }
            else
            {
                singlePlayerGameMode = false;
                return singlePlayerGameMode;
            }

        }

        public void DeterminePlayers()
        {
            bool singlePlayerGameMode = DetermineGameType();
            if (singlePlayerGameMode == true)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
        }



        public string ExecuteRound()
        {
            int playerOneChoice = playerOne.DetermineGesture();
            int playerTwoChoice = playerTwo.DetermineGesture();

            int roundValue = (5 + playerOneChoice - playerTwoChoice) % 5;

            if (roundValue == 1 || roundValue == 3)
            {
                Console.WriteLine("Player One Wins!");
                string winner = "Player One Wins!";
                return winner;
            }
            else if (roundValue == 2 || roundValue == 4)
            {
                Console.WriteLine("Player Two Wins!");
                string winner = "Player Two Wins!";
                return winner;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                return null;
            }
            
        }
        public string TrackWinsPerPlayer()
        {
            string roundWin = ExecuteRound();

            if (roundWin == "Player One Wins!")
            {
                playerOne.roundWins.Add(1);
                playerOne.roundWins.ForEach(Console.WriteLine);
                return Console.ReadLine();
            }
            else if (roundWin == "Player Two Wins!")
            {
                playerTwo.roundWins.Add(1);
                playerTwo.roundWins.ForEach(Console.WriteLine);
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It's a tie, play again!");
                return null;
            }           
        }

        public void DetermineWinner()
        {
            if(playerOne.roundWins.Count == 2)
            {
                Console.WriteLine(playerOne.playerName + " wins!!");
                winner = true;
                
            }
            else if(playerTwo.roundWins.Count == 2)
            {
                Console.WriteLine(playerTwo.playerName + " wins!!");
                winner = true;
            }
        }
    }
}

