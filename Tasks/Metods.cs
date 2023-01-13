using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks
{
    class Metods
    {
        public void Task1(int oneNumber, int twoNumber)
        {
            if (oneNumber == twoNumber)
            {
                Console.WriteLine("Два числа равны");
            }
            if (oneNumber > twoNumber)
            {
                Console.WriteLine("Первое число больше второго");
            }
            if (oneNumber < twoNumber)
            {
                Console.WriteLine("Первое число меньше второго");
            }
        }

        public void Task2(int number)
        {
            if (number > 5 && number < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        public void Task3(int number)
        {
            if (number == 5 || number == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        public void Task4(double number, double year)
        {
            if (year >= 3)
            {
                if (number < 100)
                {
                    number += number * 0.07 * year;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                }
                else if (number < 200)
                {
                    number += number * 0.09 * year;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                }
                else if (number > 200)
                {
                    number += number * 0.12 * year;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                }
            }
            else
            {
                Console.WriteLine("Вклад выдается от 3-х лет");
            }

        }


        public void Task5(double number, double year, double bonus)
        {
            double result;

            if (year >= 3)
            {
                if (number < 100)
                {
                    number += number * 0.07 * year;
                    result = number + bonus;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                    Console.WriteLine("Финальная сумма с начисленным процентами и бонусом от банка: " + result);
                }
                else if (number < 200)
                {
                    number += number * 0.09 * year;
                    result = number + bonus;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                    Console.WriteLine("Финальная сумма с начисленным процентами и бонусом от банка: " + result);
                }
                else
                {
                    number += number * 0.12 * year;
                    result = number + bonus;
                    Console.WriteLine("Сумма с начисленным процентами: " + number);
                    Console.WriteLine("Финальная сумма с начисленным процентами и бонусом от банка: " + result);
                }
            }
            else
            {
                Console.WriteLine("Вклад выдается от 3-х лет");
            }
        }

    }
}
