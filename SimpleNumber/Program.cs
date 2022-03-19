using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            bool IsResult = UserNumber % 2 == 0;

            if (UserNumber <= 0)
            {
                Console.WriteLine("Необходимо ввести целое положительное число!");
            }

            if (UserNumber > 0)
            {
                while (true)
                {
                    if (IsResult == true)
                    {
                        Console.WriteLine($"Число {UserNumber} не является простым");
                        break;
                    }

                    else if (IsResult == false)
                    {
                        Console.WriteLine($"Число {UserNumber} является простым");
                        break;
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
