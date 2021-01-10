using System;

using System.Threading;


namespace TIC_TAC_TOE_pt_1

{

    class Program

    {


        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1;

        static int choice;




        static int flag = 0;



        static void Main(string[] args)

        {

            do

            {

                Console.Clear();

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                if (player % 2 == 0)

                {

                    Console.WriteLine("Player 2 Chance");

                }

                else

                {

                    Console.WriteLine("Player 1 Chance");

                }

                Console.WriteLine("\n");

                Board();

                choice = int.Parse(Console.ReadLine());





                if (arr[choice] != 'X' && arr[choice] != 'O')

                {

                    if (player % 2 == 0)

                    {

                        arr[choice] = 'O';

                        player++;

                    }

                    else

                    {

                        arr[choice] = 'X';

                        player++;

                    }

                }

                else

                {

                    Console.WriteLine("Illegal Move! Sorry the row {0} is already marked with {1} ", choice, arr[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Please wait 2 second board is loading again.....");

                    Thread.Sleep(2000);

                }



            } while (flag != 1 && flag != -1);



            Console.Clear();
            Console.WriteLine();

            Board();



            if (flag == 1)

            {

                Console.WriteLine();

            }

            else

            {

                Console.WriteLine();

            }

            Console.ReadLine();

        }

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }   
        
    }
}

