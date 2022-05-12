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
        
    }

}
