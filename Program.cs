using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
       

        static void S1()
        {
            //Вывести на экран число  с точностью до сотых.
            float number = 10.1234f;
            Console.WriteLine(number);

        }

        static void S1_2()
        {
            //Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            double a = Math.E;
            a = Math.Round(a, 1);
            Console.WriteLine(a);
        }
        
        static void S1_3_4()
        {
            //Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
            //Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

            Console.WriteLine("Введите число");

            var number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вы ввели число:{number}");
        }

        static void S1_5_6()
        {
            //Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
            //Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
            var number1 = 1;
            var number2 = 13;
            var number3 = 49;

            Console.WriteLine($@"{number1} {number2} {number3}");
            Console.WriteLine($@"{number1}  {number2}  {number3}");
        }

        static void S1_7()
        {
            //Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Console.WriteLine("Введите три любых числа");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());


            Console.WriteLine($@"{number1}  {number2}  {number3}");
        }

        static void S1_8()
        {
            //Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
            Console.WriteLine("Введите три любых числа");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());


            Console.WriteLine($@"{number1} {number2} {number3} {number4}");
        }

        static void S1_9() 
        {
            //Вывести на экран числа 50 и 10 одно под другим.
            var number1 = 10;
            var number2 = 50;
            Console.WriteLine($"{number2} \n {number1}");
        }

        static void S1_10() 
        {
            //Вывести на экран числа 5, 10 и 21 одно под другим.
            var number1 = 5;
            var number2 = 10;
            var number3 = 21;
            Console.WriteLine($"{number2}\n{number1}\n{number3}");
        }

        static void S1_11() 
        {
            //Составить программу вывода на экран «столбиком» четырех любых чисел.
            Random random = new Random();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", random.Next(), random.Next(), random.Next(), random.Next());
        } 

        static void S1_12() 
        {
            //Составить программу вывода на экран следующей информации:
            //5 10
            //7 см
            
            
            Console.WriteLine($"{5} {10}\n{7}cm");
        }

        static void S1_13() 
        {
            //Составить программу вывода на экран следующей информации:
            // 2 кг
            // 13 17
            Console.WriteLine($"{2}KG \n{13} {17}");
        }

        static void S2_1()
        {

            //Составить программу:
            //а) вычисления значения функции y = 7x2 + 3x + 6 при любом значении x;
            //б) вычисления значения функции x = 12a2 + 7a + 12 при любом значении а.

            Random random = new Random();
            var y = 7 * Math.Pow(random.Next(1, 10), 2) + 3 * random.Next(1, 10) + 6;
            Console.WriteLine(y);


            var x = 12 * Math.Pow(random.Next(1, 10), 2) + 7 * random.Next(1, 10) + 12;
            Console.WriteLine(x);

        }

        static void S2_2()
        {
            //Дана сторона квадрата.Найти его периметр
            Console.WriteLine("Укажите длину стороны квадрата");
            var q = int.Parse(Console.ReadLine());
            var p = Math.Pow(q, 2);
            Console.WriteLine(p);
        }

        static void S2_3()
        {
            //Дан радиус окружности. Найти ее диаметр.

                Console.WriteLine("Какой радиус окружности");

                var R = int.Parse(Console.ReadLine());

                var D = 2 * R;

                Console.WriteLine(D);
        }

        static void S2_4()
        {
            
        }
        
        static void dzIfMetanit()
        {
            Console.WriteLine("Введите сумму своего вклада");
            var sumS = double.Parse(Console.ReadLine());
            double result = 0;

            if (sumS <= 100)
            {
                result = sumS * 0.05;
                Console.WriteLine($"Вам начисляется 5 %, ваш процент составляет : {result}");
            }
            else if (sumS > 100 && sumS < 200)
            {
                result = sumS * 0.07;
                Console.WriteLine($"Вам начисляется 7 %, ваш процент составляет : {result}");
            }
            else if (sumS > 200)
            {
                result = sumS * 0.1;
                Console.WriteLine($"Вам начисляется 10 %, ваш процент составляет : {result}");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"Итоговая сумма: {sumS + result}");
        }

        static void dzfor1Metanit()
        {
            //За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

            //Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine())(сумма вклада будет представлять тип decimal).
            Console.WriteLine("Введите сумму вклада");
            var sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            var months = int.Parse(Console.ReadLine());


            for (int m = 0; m < months; m++)
            {
                sum += sum * 0.7M;

            }
            Console.WriteLine($"После {months} месяцев сумма вклада составит {sum}");
        }

        static void dzfor2Metanit()
        {

            //Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
            Console.WriteLine("Введите сумму вклада");
            var sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            var months = int.Parse(Console.ReadLine());
            var i = months;
            while (i > 0)
            {
                sum += sum * 0.7M;
                i--;
            }

            Console.WriteLine($"После {months} месяцев сумма вклада составит {sum}");
        }

        static void dzfor3Metanit()
        {
            //Напишите программу, которая выводит на консоль таблицу умножения.



            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }

        static void dzfor4Metanit()
        {
            while (true)
            {
                /* Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.

                  Для организации ввода чисел используйте бесконечный цикл while и оператор break.*/
                Console.WriteLine("Введите первое число в диапазоне от 0 до 10");
                var num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число в диапазоне от 0 до 10");
                var num2 = int.Parse(Console.ReadLine());

                if (num1 > 0 || num1 <= 0 || num2 > 0 || num2 <= 10)
                {
                    Console.WriteLine("готово");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверноые числа");
                }
                Console.WriteLine($" Условие выполнено: {num1 * num2}");
                break;
            }
        }

        static void dzWhileYoutube()
        {
            //Сумма и количество четных и нечетных чисел.
            Console.WriteLine("Введите число");

            var inenger = int.Parse(Console.ReadLine());

            var count = 0;
            var sumInt = 0;
            var sumOdd = 0;
            var sumInt1 = 0;
            var sumOdd1 = 0;


            while (count < inenger)
            {
                count++;

                if (count % 2 == 0)
                {
                    sumInt += count;
                    sumInt1++;

                }
                else
                {
                    sumOdd += count;
                    sumOdd1++;
                }





            }

            Console.WriteLine($"Количество четных чисел: {sumInt1}");
            Console.WriteLine($"Количество нечетных чисел: {sumOdd1}");
            Console.WriteLine($"Сумма четных чисел: {sumInt}");
            Console.WriteLine($"Сумма нечетных чисел: {sumOdd}");
        }
        
    }

}
