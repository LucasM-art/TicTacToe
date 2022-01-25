using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TicTacToe2._0
{
    internal class Program
    {
        public static bool isPlaying = true; // bool to see if the game is still happening

        // player
        public static int player = 1;

        // user's input
        public static string playerInput;

        public static bool valid;

        // number choice
        public static int choice;
        public static string symbol;
        public static string reset = "restart";

        // tic tac toe
        static string[,] ticTac = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        static void Main(string[] args)
        {
            Executing();

            Console.ReadKey();
        }

        static void Executing()
        {
            do
            {
                Console.Clear();
                Board();

                PlayerCommands();

                GameMech();

            } while (isPlaying);

            Console.Clear();
            Board();

            Console.WriteLine("Player {0} won!", (player % 2) + 1);
            Console.ReadLine();

            Console.WriteLine("Restart?");
            string answer = Console.ReadLine();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("Please wait");
                Thread.Sleep(2000);

                Console.Clear();

                ticTac = new string[,]
                {
                    {"1", "2", "3"},
                    {"4", "5", "6"},
                    {"7", "8", "9"}
                };

                player = 1;
                isPlaying = true;
                Board();
                Executing();
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("bye");
            }
        }

        static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", ticTac[0, 0], ticTac[0, 1], ticTac[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", ticTac[1, 0], ticTac[1, 1], ticTac[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", ticTac[2, 0], ticTac[2, 1], ticTac[2, 2]);
            Console.WriteLine("     |     |      ");
        }

        static void PlayerCommands()
        {
            if (player % 2 == 1)
            {
                symbol = "X";

                Console.WriteLine("Player 1: Choose a number!");
                playerInput = Console.ReadLine();
                int.TryParse(playerInput, out choice);
            }
            else
            {
                symbol = "O";

                Console.WriteLine("Player 2: Choose a number!");
                playerInput = Console.ReadLine();
                int.TryParse(playerInput, out choice);
            }

            if (playerInput == reset)
            {
                Console.WriteLine("Please wait");
                Thread.Sleep(2000);

                Console.Clear();

                ticTac = new string[,]
                {
                    {"1", "2", "3"},
                    {"4", "5", "6"},
                    {"7", "8", "9"}
                };

                player = 1;
                isPlaying = true;
                Board();
                Executing();
            }

            switch (choice)
            {
                case 1:
                    valid = CheckSpaces(ticTac[0, 0]);
                    if (!valid)
                    {
                        ticTac[0, 0] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 2:
                    valid = CheckSpaces(ticTac[0, 1]);
                    if (!valid)
                    {
                        ticTac[0, 1] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 3:
                    valid = CheckSpaces(ticTac[0, 2]);
                    if (!valid)
                    {
                        ticTac[0, 2] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 4:
                    valid = CheckSpaces(ticTac[1, 0]);
                    if (!valid)
                    {
                        ticTac[1, 0] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 5:
                    valid = CheckSpaces(ticTac[1, 1]);
                    if (!valid)
                    {
                        ticTac[1, 1] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 6:
                    valid = CheckSpaces(ticTac[1, 2]);
                    if (!valid)
                    {
                        ticTac[1, 2] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 7:
                    valid = CheckSpaces(ticTac[2, 0]);
                    if (!valid)
                    {
                        ticTac[2, 0] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 8:
                    valid = CheckSpaces(ticTac[2, 1]);
                    if (!valid)
                    {
                        ticTac[2, 1] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                case 9:
                    valid = CheckSpaces(ticTac[2, 2]);
                    if (!valid)
                    {
                        ticTac[2, 2] = symbol;
                        Console.Clear();
                        Board();
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Number already selected, pick another one");
                        PlayerCommands();
                    }

                    break;

                default:
                    Console.WriteLine("Please, enter another number");
                    choice = 0;
                    PlayerCommands();
                    break;
            }
        }

        static void GameMech()
        {
            if (ticTac[0, 0] == ticTac[1, 1] && ticTac[1, 1] == ticTac[2, 2])
            {
                isPlaying = false;
            }
            else if (ticTac[0, 2] == ticTac[1, 1] && ticTac[1, 1] == ticTac[2, 0])
            {
                isPlaying = false;
            }
            

            if (ticTac[0, 0] == ticTac[0, 1] && ticTac[0, 1] == ticTac[0, 2])
            {
                isPlaying = false;
            }
            else if (ticTac[1, 0] == ticTac[1, 1] && ticTac[1, 1] == ticTac[1, 2])
            {
                isPlaying = false;
            }
            else if (ticTac[2, 0] == ticTac[2, 1] && ticTac[2, 1] == ticTac[2, 2])
            {
                isPlaying = false;
            }
            

            if (ticTac[0, 0] == ticTac[1, 0] && ticTac[1, 0] == ticTac[2, 0])
            {
                isPlaying = false;
            }
            else if (ticTac[0, 1] == ticTac[1, 1] && ticTac[1, 1] == ticTac[2, 1])
            {
                isPlaying = false;
            }
            else if (ticTac[0, 2] == ticTac[1, 2] && ticTac[1, 2] == ticTac[2, 2])
            {
                isPlaying = false;
            }
        }

        static bool CheckSpaces(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
