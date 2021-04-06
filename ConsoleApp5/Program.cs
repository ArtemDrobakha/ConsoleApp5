using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        delegate int Operation(double x);
        static void Main(string[] args)
        {


            Func<double, double>[] arrLiamda = { x => Math.Sqrt(Math.Abs(x)),
                                                 x => x * x * x,
                                                 x => ++x };


            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] arr = input.Split(' ');
                    int number = Convert.ToInt32(arr[0]);
                    double value = Convert.ToDouble(arr[1]);
                    Console.WriteLine(arrLiamda[number](value));

                    /*Прочитати рядок вхідних даних, спробувати викликати потрібне обчислення
                    шляхом звернення до масиву лямбда функцій, що враховують прочитані вхідні
                    дані*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

