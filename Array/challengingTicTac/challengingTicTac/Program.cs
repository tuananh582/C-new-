using System;
namespace challengingTicTac
{
    class Program
    {
        //the playfield
        static char[,] playFiled =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };static char[,] playFiledInitial =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };
        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;//player 1 starts
            int input = 0;
            bool inputCorrect = true;


            Console.ReadKey();
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXor0('X', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXor0('O', input);

                }
                SetField();
                //Checking winning condition
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if ((playFiled[0, 0] == playerChar) && (playFiled[0, 1] == playerChar) && (playFiled[0, 2] == playerChar)
                        || ((playFiled[1, 0] == playerChar) && (playFiled[1, 1] == playerChar) && (playFiled[1, 2] == playerChar))
                        || ((playFiled[2, 0] == playerChar) && (playFiled[2, 1] == playerChar) && (playFiled[2, 2] == playerChar))
                        || ((playFiled[0, 0] == playerChar) && (playFiled[1, 1] == playerChar) && (playFiled[2, 2] == playerChar))
                        || ((playFiled[0, 2] == playerChar) && (playFiled[1, 1] == playerChar) && (playFiled[2, 0] == playerChar))
                        || ((playFiled[0, 1] == playerChar) && (playFiled[1, 1] == playerChar) && (playFiled[2, 1] == playerChar))
                        || ((playFiled[0, 0] == playerChar) && (playFiled[1, 0] == playerChar) && (playFiled[2, 0] == playerChar))
                        || ((playFiled[0, 2] == playerChar) && (playFiled[1, 2] == playerChar) && (playFiled[2, 2] == playerChar))
                      )
                    {
                        if (playerChar == 'X')
                        {
                        Console.WriteLine("\n Player 2 has won!");

                        }
                        else
                        {
                            Console.WriteLine("\n Player 1 has won");
                        }
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        RestField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\n Draw");
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        RestField();
                        break;
                    }
                }


                do
                {
                    Console.WriteLine("\n Player {0}:Choose your field", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number ");
                    }
                    if ((input == 1) && (playFiled[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playFiled[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playFiled[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playFiled[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playFiled[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playFiled[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playFiled[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playFiled[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playFiled[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another filed");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);


            } while (true);
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("       |       |     ");
            //To do replace number with variables.
            Console.WriteLine("   {0}   |   {1}   |   {2}", playFiled[0, 0], playFiled[0, 1], playFiled[0, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            //To do replace number with variables.
            Console.WriteLine("   {0}   |   {1}   |   {2}", playFiled[1, 0], playFiled[1, 1], playFiled[1, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            //To do replace number with variables.
            Console.WriteLine("   {0}   |   {1}   |   {2}", playFiled[2, 0], playFiled[2, 1], playFiled[2, 2]);
            Console.WriteLine("_______|_______|_______");
            turns++;
            //Console.WriteLine("       |       |       ");
        }

        //Reset
        public static void RestField()
        {
            playFiled = playFiledInitial;
            SetField();
            turns = 0;
        }


        public static void EnterXor0(char playerSign, int input)
        {
        
            switch (input)
            {
                case 1:
                    playFiled[0, 0] = playerSign;
                    break;
                case 2:
                    playFiled[0, 1] = playerSign;
                    break;
                case 3:
                    playFiled[0, 2] = playerSign;
                    break;
                case 4:
                    playFiled[1, 0] = playerSign;
                    break;
                case 5:
                    playFiled[1, 1] = playerSign;
                    break;
                case 6:
                    playFiled[1, 2] = playerSign;
                    break;
                case 7:
                    playFiled[2, 0] = playerSign;
                    break;
                case 8:
                    playFiled[2, 1] = playerSign;
                    break;
                case 9:
                    playFiled[2, 2] = playerSign;
                    break;
            }

        }

    }


}


