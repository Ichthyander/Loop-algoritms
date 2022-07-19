using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
 * Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.*/

namespace task3_while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter initialization
            int squareCount = 0;

            Console.WriteLine("Введите последовательно три целых числа A, B, C");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            //Loop counter initialization
            int localA = A;
            while (localA >= C)
            {
                //Local loop counter initialization
                int localB = B;
                while (localB >= C)
                {
                    squareCount += 1;
                    localB -= C;
                }

                localA -= C;
            }

            Console.WriteLine("В прямоугольник со сторонами {0}x{1} вмещается {2} квадратов со стороной {3}", A, B, squareCount, C);
            Console.ReadKey();
        }
    }
}
