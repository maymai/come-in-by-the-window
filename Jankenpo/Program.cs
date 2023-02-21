using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        private const int Rock = 1;
        private const int Paper = 2;
        private const int Scissors = 3;

        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            
            do
            {
                int computerValue = SetComputerValue();
                string computerChoice = GetChoiceByValue(computerValue);
                int playerValue = GetPlayerValue();
                string playerChoice = GetChoiceByValue(playerValue);

                Console.WriteLine(
                    $"\nPlayer chose {playerChoice}," +
                    $"\nComputer chose {computerChoice}.");

                if (playerValue == 0)
                {
                    break;
                }
                else if ((playerValue - 1 == computerValue)
                    || (playerValue == Rock && computerValue == Scissors))
                {
                    Console.WriteLine("\n+++ Player wins! +++");
                    playerScore++;
                }
                else if ((computerValue - 1 == playerValue)
                    || (computerValue == Rock && playerValue == Scissors))
                {
                    Console.WriteLine("\n*** The computer wins! ***");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("\n--- It's a draw! ---");
                }
                
                Console.WriteLine($"\nTotal score:\n" +
                    $"Player:   {playerScore}\n" +
                    $"Computer: {computerScore}");

            } while(true);
        }

        private static int SetComputerValue()
        {
            Random randomNumbers = new Random();
            int computerValue = randomNumbers.Next(1,4);

            return computerValue;
        }

        private static int GetPlayerValue()
        {
            int playerValue = -1;
            do
            {
                Console.Write(
                    "\nPlease choose:\n" +
                    "1 - Rock\n" +
                    "2 - Paper\n" +
                    "3 - Scissors\n" +
                    "q - Quit\n");

                char playerChoice = Char.ToLower(Console.ReadKey(true).KeyChar);

                switch (playerChoice)
                {
                    case '1':
                    case 'r':
                        playerValue = Rock;
                        break;
                    case '2':
                    case 'p':
                        playerValue = Paper;
                        break;
                    case '3':
                    case 's':
                        playerValue = Scissors;
                        break;
                    case 'q':
                        playerValue = 0;
                        break;
                    default:
                        playerValue = -1;
                        Console.WriteLine($"{playerChoice} is not a valid choice. Please choose again.");
                        break;
                }
            } while (playerValue == -1);

            return playerValue;
        }

        private static string GetChoiceByValue(int value)
        {
            switch (value)
            {
                case Rock:
                    return "Rock";
                case Paper:
                    return "Paper";
                case Scissors:
                    return "Scissors";
                default:
                    return "quit";
                    break;
            }
        }
    }
}
