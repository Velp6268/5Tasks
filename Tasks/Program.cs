using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            Metods metods = new Metods();
          
            do
            {
                Console.Clear();
               

                Console.WriteLine("Введите номер задания: ");
                int numberTask = Convert.ToInt32(Console.ReadLine());
                switch (numberTask)
                {
                    case 1:
                        Console.WriteLine("\nЗадание 1: Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. " +
                            "А программа сравнивает два введенных числа и выводит на консоль результат сравнения " +
                            "(два числа равны, первое число больше второго или первое число меньше второго).\n");

                        Console.WriteLine("Введите первое число: ");
                        int oneNumberT1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        int twoNumberT1 = Convert.ToInt32(Console.ReadLine());

                        metods.Task1(oneNumberT1, twoNumberT1);
                        break;
                    case 2:
                        Console.WriteLine("\nЗадание 2: Напишите консольную программу, в которую пользователь вводит с клавиатуры число. " +
                            "Если число одновременно больше 5 и меньше 10, то программа выводит \"Число больше 5 и меньше 10\". " +
                            "Иначе программа выводит сообщение \"Неизвестное число\". \n");

                        Console.WriteLine("Введите число");
                        int numberT2 = Convert.ToInt32(Console.ReadLine());

                        metods.Task2(numberT2);
                        break;
                    case 3:
                        Console.WriteLine("\nЗадание 3: Напишите консольную программу, в которую пользователь вводит с клавиатуры число. " +
                            "Если число либо равно 5, либо равно 10, то программа выводит \"Число либо равно 5, либо равно 10\". " +
                            "Иначе программа выводит сообщение \"Неизвестное число\".\n");

                        Console.WriteLine("Введите число: ");
                        int numberT3 = Convert.ToInt32(Console.ReadLine());

                        metods.Task3(numberT3);
                        break;
                    case 4:
                        Console.WriteLine("\nЗадание 4: В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. " +
                            "Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, " +
                            "то начисляется 7%. Если сумма вклада от 100 до 200, то начисляется 9%. Если сумма вклада больше 200, то начисляется 12%. " +
                            "В конце программа должна выводить сумму вклада с начисленными процентами.\n");

                        Console.WriteLine("Внесите сумму вклада:");
                        double numberT4 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Введите на сколько лет хотите взять в клад: ");
                        double yearT4 = Convert.ToDouble(Console.ReadLine());

                        metods.Task4(numberT4, yearT4);
                        break;
                    case 5:
                        Console.WriteLine("\nЗадание 5: Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. " +
                            "И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. " +
                            "Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.\n");

                        Console.WriteLine("Внесите сумму вклада:");
                        double numberT5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите на сколько лет хотите взять в клад: ");
                        double yearT5 = Convert.ToDouble(Console.ReadLine());
                        double bonusT5 = 15;

                        metods.Task5(numberT5, yearT5, bonusT5);
                        break;


                }

                Console.WriteLine("\nЧто бы закончить, нажмите клавишу 'q', если хотите продолжить нажмите любую клавишу. ");
                cki = Console.ReadKey(true);

            } while(cki.Key != ConsoleKey.Q);

        }
    }
}
