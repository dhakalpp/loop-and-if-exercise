using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 7;
            Console.WriteLine("* >>>> for loop <<< *");
            /*for loop*/
            for (int i = start; 1 <= finish; i++)

            {
                Console.WriteLine($"(1)\t(1*10)\t(1*100)\t(1*1000)");
            }
            Console.WriteLine("ln >>> while loop <<<");
            //lnt counter 1 = start;
            /*while loop*/
            while (start <= finish)
            {
                Console.WriteLine($"(start)\t(start*10)\t(start*100)\t(start*1000)");
                start++;
            }
            Console.WriteLine("/ln>>> do while loop <<<<"); 
            start = 3;
            do
            {
                Console.WriteLine($"(start)\t(start*10)\t(start*100)\t(start*1000)");
            }
            while (start <= finish);
            Console.WriteLine("task 1 complete");
            Console.ReadLine();
                    
            /* Task 2 */
                Console.Clear();
            int number = 7;
            Console.WriteLine(" 7 times table:");
            Console.WriteLine( "-----------" );
            Console.WriteLine("* >>>> for loop <<< *");
            int counter = 1;
            while (counter <= 12)
            {
                Console.WriteLine($"{counter}* {number} = {counter = number} ");
                counter++;
            }
            Console.WriteLine("ln >>>> do while loop <<<<");
            /*while loop*/
            counter = 1;
            do
            {
                Console.WriteLine($"{counter}* {number} = {counter = number} ");
                counter++;
            } while (counter <= 12);

            Console.WriteLine("task 2 complete");
            Console.ReadLine();

            /* Task 3 */
            Console.Clear();
            Console.WriteLine("number\t square\t cube");
            Console.WriteLine("......\t......\t......\t");
            /*for loop*/
            Console.WriteLine("* >>>> for loop <<< *");
            for (int i = 0; 1 <= 10; i++)
            {

            }
        }
    }
}
