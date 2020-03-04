using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {

        public static int AskInt(string input)
        {
            bool menu = false;
            int answer = 0;

            do
            {
                System.Console.Clear();
                System.Console.CursorVisible = true;
                try
                {
                    System.Console.Write(input);
                    answer = int.Parse(System.Console.ReadLine());
                    if (answer > 0)
                    {
                        menu = true;
                        
                    }
                    else
                    {
                        System.Console.Clear();
                        System.Console.CursorVisible = false;
                        System.Console.WriteLine("Please enter a positive integer. Press any key to continue...");
                        System.Console.ReadKey();
                    }



                }
                catch (FormatException e)
                {
                    System.Console.Clear();
                    System.Console.CursorVisible = false;
                    System.Console.WriteLine("Please enter a positive integer. Press any key to continue...");
                    System.Console.ReadKey();
                }
            } while (!menu);

            return answer;

        }

        public static string UserPlay(string input)
        {
            bool menu = false;
            string answer;

            do
            {
                System.Console.Clear();
                System.Console.CursorVisible = true;
                
                System.Console.Write(input);
                answer = (System.Console.ReadLine().ToUpper());
                if (answer == "ROCK" || answer == "PAPER" || answer == "SCISSORS")
                {
                    menu = true;
                }
                else
                {
                    System.Console.Clear();
                    System.Console.CursorVisible = false;
                    System.Console.WriteLine("Please enter Rock, Paper, or Scissors. Press any key to continue...");
                    System.Console.ReadKey();
                }
            
            } while (!menu);

            return answer;

        }

    }
}
