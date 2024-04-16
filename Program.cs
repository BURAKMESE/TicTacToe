using System;
using System.Threading;
namespace TIC_TAC_TOE
{
    class Program
    {
        //0 ile 9 arasındaki sayılar yerleşim yerini belirlemek için kullanılacak 
        //        Console.WriteLine("Oynamak istediğiniz karenin sahip olduğu sayıyı yazın)

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice; 

        static int flag = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Oynamak istediğiniz karenin sahip olduğu sayıyı yazın);
        }
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Oyuncu1:X ve Oyuncu2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Sıra ikinci oyuncuda");
                }
                else
                {
                    Console.WriteLine("Sıra birinci oyuncuda");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
               
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //eğer şans 2. oyuncudaysa O'yu işaretle. Değilse X işaretle
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
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
          
            Console.Clear();
            Board();
            if (flag == 1)
           
            {
                Console.WriteLine("Oyuncu {0} Kazandı", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
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
        
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
-            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}