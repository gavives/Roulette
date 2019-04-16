using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_game
{
    
        class Program
        {
            static void DoWork()
            {
                Intro();
                Console.WriteLine("Choose a number (1-10) that corresponds to the game you want to play: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                GameChoice(choice);
                Console.WriteLine();
                Console.WriteLine("Press Enter:");
            }

            public static void Intro()
            {
                Console.WriteLine("Roulette Wheel Game");
                Console.WriteLine("These are the different games you can play in Roulette.");
                Console.WriteLine();

                Console.WriteLine("\n1. Numbers: the number of the bin" +
                    "\n2. Evens/Odds: even or odd numbers" +
                    "\n3. Reds/Blacks: red or black colored numbers" +
                    "\n4. Lows/Highs: low (1-18) or high (19-38) numbers." +
                    "\n5. Dozens: row thirds, 1-12, 13-24, 25-36" +
                    "\n6. Columns: First, second, or third columns" +
                    "\n7. Street: rows, e.g., 1/2/3 or 22/23/24" +
                    "\n8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26" +
                    "\n9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36" +
                    "\n10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
                Console.WriteLine();
            }
            public static void GameChoice(int choice)
            {

                Console.WriteLine($"You chose bet {choice}");
                switch (choice)
                {
                    case 1:
                        Choice1();
                        break;
                    case 2:
                        Choice2();

                        break;
                    case 3:
                        Choice3();

                        break;
                    case 4:
                        Choice4();

                        break;
                    case 5:
                        Choice5();

                        break;
                    case 6:
                        Choice6();

                        break;
                    case 7:
                        Choice7();

                        break;
                    case 8:
                        Choice8();

                        break;
                    case 9:
                        Choice9();

                        break;
                    case 10:
                        Choice10();

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("That is not one of the choices\n");
                        Console.Clear();
                        Intro();
                        Console.WriteLine("Choose another bet (1-10)");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        GameChoice(newNumber);
                        return;
                }

            }

            public static int RandoNum()
            {
                Random random = new Random();
                int ran = random.Next(0, 37);
                return ran;
            }
            public static char RandoCol()
            {
                Random random = new Random();

                int ran = random.Next(0, 37);
                char wheelcolor = (char)(ran);
                return wheelcolor;
            }
            public static int RouletteNum()
            {
                int[] wheelNumbers = new int[] { 30, 7, 32, 5, 34, 3, 36, 1, 27, 25, 12, 19, 18, 21, 16, 23, 14, 11, 20, 32, 17, 22, 15, 24, 13, 10, 29, 8, 31, 6, 33, 4, 35, 2, 0, 00 };
                return wheelNumbers[RandoNum()];
            }
            public static char RouletteColor()
            {
                char[] colorWheel = new char[] { 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'g', 'g' };
                return colorWheel[RandoCol()];
            }


            public static void Choice1()
            {
                
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The number on the wheel is " + temp);
                if (num == temp)
                {
                    Console.WriteLine("Congrats you win $" + bet * 36);
                }
                else
                    Console.WriteLine("You lost $" + bet);
                PlayAgain();
            }
            public static void Choice2()
            {
               
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press Enter:");
                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);


                if (temp % 2 == 0)//even 
                {
                    Console.WriteLine($"You won${bet * 12}!");
                }

                else
                {
                    Console.WriteLine($"You lost! {bet}");
                }
                PlayAgain();


            }
            public static void Choice3()
            {
               
                char temp = RouletteColor();
                Console.WriteLine("Please choose b for black, r for red, or g for green");
                char color = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The color on the wheel is " + temp);

                if (temp == 'r')
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (temp != 'r')
                {
                    Console.WriteLine($"You lose$ {bet}");
                }

                else if (temp == 'g')
                {
                }
                else
                {
                    Console.WriteLine($"You lose$ {bet}");
                }
                PlayAgain();

            }
            public static void Choice4()
            {
               
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);



                if (temp <= 18 && temp >= 0)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else
                {
                    Console.WriteLine($"You lose$ {bet}");
                }

                PlayAgain();

            }
            public static void Choice5()
            {
                
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);


                if (temp > 24 && num <= 36)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }

                else if (temp > 12 && num <= 24)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                    temp >= 0 && num <= 12)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else
                {
                    Console.WriteLine($"You lose$ {bet}");
                }
                PlayAgain();

            }
            public static void Choice6()
            {
               
                int temp = RouletteNum();
                Console.WriteLine("Please choose column 1, 2 , or 3");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);

                if (num == 1)
                {
                    if (temp % 3 == 1)
                    {
                        Console.WriteLine($"You Won! ${bet * 3}");
                    }
                    else
                    {
                        Console.WriteLine($"You lost ${bet} ");
                    }
                }
                else if (num == 2)
                {
                    if (temp % 3 == 2)
                    {
                        Console.WriteLine($"You Won! ${bet * 3}");
                    }
                    else
                    {
                        Console.WriteLine($"You lost ${bet} ");
                    }
                }
                else if (num == 3)
                {
                    if (temp % 3 == 0)
                    {
                        Console.WriteLine($"You Won! ${bet * 3}");
                    }
                    else if (temp == 0)
                    {
                        Console.WriteLine($"You lost ${bet} ");
                    }
                    else
                    {
                        Console.WriteLine($"You lost ${bet} ");
                    }
                }

                PlayAgain();

            }
            public static void Choice7()
            {
                
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);


                if (temp > 34 && num <= 36)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }

                else if (temp > 31 && num <= 34)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                    temp > 28 && num <= 31)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                   temp > 25 && num <= 28)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                  temp > 22 && num <= 25)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                  temp > 19 && num <= 22)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                  temp > 13 && num <= 16)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                 temp > 10 && num <= 13)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                 temp > 7 && num <= 10)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                 temp > 4 && num <= 7)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                temp > 1 && num <= 4)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else
                {
                    Console.WriteLine($"You lose$ {bet}");
                }
                PlayAgain();

            }
            public static void Choice8()
            {
                
                int temp = RouletteNum();
                Console.WriteLine("Please choose a number to place on the table");
                int num = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);

                if (temp > 30 && num <= 36)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }

                else if (temp > 24 && num <= 30)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                    temp > 18 && num <= 24)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                   temp > 12 && num <= 18)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                  temp > 6 && num <= 12)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else if (
                  temp >= 0 && num <= 6)
                {
                    Console.WriteLine($"You win$ {bet * 12}");
                }
                else
                {
                    Console.WriteLine($"You lose$ {bet}");
                }

                PlayAgain();

            }
            public static void Choice9()
            {
               
                int temp = RouletteNum();
                Console.WriteLine("For this game, you will choose two numbers for a split bet");
                Console.Write("Choose for your first number.");
                int num01 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose you second number.");
                int num02 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);


                if (num01 == temp || num02 == temp)
                {
                    Console.WriteLine($"You chose {num01}/{num02}, You win ${bet * 8}");
                }
                else
                {
                    Console.WriteLine($"You chose {num01}/{num02}, You win ${bet}");
                }
                PlayAgain();

            }
            public static void Choice10()
            {
                
                int temp = RouletteNum();
                Console.WriteLine("For this bet, you will have to choose 4 numbers.");
                Console.Write("Choose for your first number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose for your second number.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose for your third number.");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose for your fourth number.");
                int num4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number on the wheel is " + temp);


                if (num1 == temp || num2 == temp || num3 == temp || num4 == temp)
                {
                    Console.WriteLine($"You Won!!!!, your numbers were {num1}/{num2}/{num3}/{num4}, you won {bet * 12}");
                }
                else
                {
                    Console.WriteLine($"You lost, your numbers were {num1}/{num2}/{num3}/{num4}, you lost {bet * 4}");

                }
                PlayAgain();
            }


            public static void PlayAgain()
            {
                Console.WriteLine("Do you want to play again: y/n");
                string play = Console.ReadLine();
                if (play == "y")
                {
                    Console.Clear();
                    Intro();
                    Console.WriteLine("Choose another number to play another game");
                    int newNumber = Convert.ToInt32(Console.ReadLine());
                    GameChoice(newNumber);
                }
                else if (play != "y")
                {
                    ThanksForPlaying();
                }
            }
            public static void ThanksForPlaying()
            {
                Console.Clear();
                Console.WriteLine("Thanks for Playing!!!!\r\nPress Enter to Exit:");
                Console.ReadLine();
            }
        static void Main(string[] args)
        {
             DoWork();
        }
    }
    
}

