using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных 
 * или количество отрицательных. Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/

namespace task2_do_while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализируем счётчик количества положительных и отрицательных чисел
            int p_n_compare = 0;
            Console.WriteLine("Введите 1-е число последовательности");

            do
            {
                int inputNum = Convert.ToInt32(Console.ReadLine());

                if (inputNum == 0)
                {
                    break;
                }
                    else if (inputNum > 0)
                {
                    p_n_compare++;
                }
                else
                {
                    p_n_compare--;
                }

                Console.WriteLine("Введите следующее число последовательности или число \"0\" для получения результата");

            } while (true);

            //Проверка итогового значения в счётике для вывода сообщения
            if (p_n_compare > 0)
            {
                Console.WriteLine("Количество положительных чисел в последовательности больше количества отрицательных");
            }
            else if (p_n_compare < 0)
            {
                Console.WriteLine("Количество отрицательных чисел в последовательности больше количества положительных");
            }
            else
            {
                Console.WriteLine("Количество отрицательных чисел в последовательности равняется количеству положительных");
            }

            Console.ReadKey();
        }
    }
}
