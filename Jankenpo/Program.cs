using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;

        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;

            string quitGame;
            do
            {
                int computerValue = SetComputerValue();
                string computerChoice = GetChoiceByValue(computerValue);
                int playerValue = GetPlayerValue();
                string playerChoice = GetChoiceByValue(playerValue);


                Console.WriteLine($"Computer chose {computerChoice}, \nplayer chose {playerChoice}.");
                if (playerValue == computerValue)
                {
                    Console.WriteLine("\n---It's a draw!---");
                }
                else if ((playerValue - 1 == computerValue)
                    || (playerValue == Rock && computerValue == Scissors))
                {
                    Console.WriteLine("\n+++Player wins!+++");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("\n***The computer wins!***");
                    computerScore++;
                }

                Console.WriteLine($"Total score: Player: {playerScore} | Computer: {computerScore}");
                Console.WriteLine("Quit(q)? Or press any key to continue.");
                quitGame = Console.ReadLine().ToLower();

            } while (!((quitGame == "y") || (quitGame == "yes") || (quitGame == "q") || (quitGame == "quit")));
        }

        private static int SetComputerValue()
        {
            Random randomNumbers = new Random();
            int computerValue = randomNumbers.Next(3);

            return computerValue;
        }

        private static int GetPlayerValue()
        {
            int playerValue = -1;
            do
            {
                Console.Write("" +
                    "Please enter\n" +
                    "1 - Rock\n" +
                    "2 - Paper\n" +
                    "3 - Scissors\n");

                string playerChoice = Console.ReadLine().ToLower();

                if (playerChoice.Equals("rock") || playerChoice.Equals("1") || playerChoice.Equals("r"))
                {
                    playerValue = Rock;
                }
                else if (playerChoice.Equals("paper") || playerChoice.Equals("2") || playerChoice.Equals("p"))
                {
                    playerValue = Paper;
                }
                else if (playerChoice.Equals("scissors") || playerChoice.Equals("3") || playerChoice.Equals("s"))
                {
                    playerValue = Scissors;
                }
                else
                {
                    playerValue = -1;
                    Console.WriteLine($"{playerChoice} is not a valid choice. Please choose again.");
                    continue;
                }
            } while (playerValue == -1);

            return playerValue;
        }

        private static string GetChoiceByValue(int value)
        {
            string choice;
            if (value == Rock)
            {
                choice = "Rock";
            }
            else if (value == Paper)
            {
                choice = "Paper";
            }
            else
            {
                choice = "Scissors";
            }
            return choice;
        }
    }
}
