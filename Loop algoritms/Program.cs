using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N^2=1 + 3 + 5 + ... + (2*N – 1).
 * После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).*/

namespace task1_for_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (N < 1)
            {
                Console.WriteLine("Вы ввели число, не удовлетворяющее условию задачи");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    result += 2 * i - 1;
                    Console.WriteLine("Для N = {0} значение N^2 равняется {1}", i, result);
                }
            }

            Console.ReadKey();
        }
    }
}
