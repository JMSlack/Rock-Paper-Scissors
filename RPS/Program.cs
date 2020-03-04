using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GameEngine();
        }

        public void GameEngine()
        {
            bool gameLoop = false;

            do
            {

                Random prng = new Random();

                int roundNumber = Util.Console.AskInt("Welcome to Rock, Paper, Scissors!\n\nHow many rounds to win?: ");
                Console.Clear();

                int userScore = 0;
                int compScore = 0;


                do
                {

                    string userPlay = Util.Console.UserPlay("Please enter Rock, Paper, or Scissors: ");

                    int computerPlay = prng.Next(0, 2);
                    switch (computerPlay)
                    {
                        case 0:
                            {
                                Console.Clear();
                                Console.WriteLine($"Computer chose: ROCK\nYou chose: {userPlay}\n");
                                if (userPlay == "ROCK")
                                {
                                    Console.WriteLine($"Draw!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else if (userPlay == "PAPER")
                                {
                                    userScore++;
                                    if (userScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Win!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    compScore++;
                                    if (compScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Lose!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }

                                break;
                            }
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine($"Computer chose: PAPER\nYou chose: {userPlay}\n");
                                if (userPlay == "ROCK")
                                {
                                    compScore++;
                                    if (compScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Lose!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else if (userPlay == "PAPER")
                                {

                                    Console.WriteLine($"Draw!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    userScore++;
                                    if (userScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Win!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine($"Computer chose: SCISSORS\nYou chose: {userPlay}\n");
                                if (userPlay == "ROCK")
                                {
                                    userScore++;
                                    if (userScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Win!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else if (userPlay == "PAPER")
                                {
                                    compScore++;
                                    if (compScore == roundNumber)
                                    {
                                        break;
                                    }
                                    Console.WriteLine($"You Lose!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {

                                    Console.WriteLine($"Draw!\n\nUser Score:          {userScore}\n" +
                                                      $"Computer Score:      {compScore}\n" +
                                                      $"Score needed to win: {roundNumber}\n\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                break;
                            }

                    }
                } while (userScore < roundNumber && compScore < roundNumber);



                if (userScore == roundNumber)
                {
                    Console.WriteLine("You Won the Game!");
                }
                else
                {
                    Console.WriteLine("You Lost the Game!");
                }

                Console.Write("\nWould you like to play again?: Y/N");
                Console.CursorVisible = false;
                var playAgain = Console.ReadKey(true).Key;
                switch (playAgain)
                {
                    case ConsoleKey.Y:
                        {
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            gameLoop = true;
                            break;
                        }


                }

            } while (!gameLoop);

        }


    }
}
