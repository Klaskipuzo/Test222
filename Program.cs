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
            float number = 10.1234f;
            Console.WriteLine(number);

        }

        static void S1_2()
        {
            double a = Math.E;
            a = Math.Round(a, 1);
            Console.WriteLine(a);
        }
        
        static void S1_3_4()
        {
            Console.WriteLine("Введите число");

            var number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вы ввели число:{number}");
        }

        static void S1_5_6()
        {
            var number1 = 1;
            var number2 = 13;
            var number3 = 49;

            Console.WriteLine($@"{number1} {number2} {number3}");
            Console.WriteLine($@"{number1}  {number2}  {number3}");
        }

        static void S1_7()
        {
            Console.WriteLine("Введите три любых числа");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());


            Console.WriteLine($@"{number1}  {number2}  {number3}");
        }

        static void S1_8()
        {
            Console.WriteLine("Введите три любых числа");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());


            Console.WriteLine($@"{number1} {number2} {number3} {number4}");
        }

        static void S1_9() {
            var number1 = 10;
            var number2 = 50;
            Console.WriteLine($"{number2} \n {number1}");
        }

        static void S1_10() 
        {
            var number1 = 5;
            var number2 = 10;
            var number3 = 21;
            Console.WriteLine($"{number2}\n{number1}\n{number3}");
        }

        static void S1_11() 
        {
            Random random = new Random();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", random.Next(), random.Next(), random.Next(), random.Next());
        } 

        static void S1_12() 
        {
            Console.WriteLine($"{5} {10}\n{7}cm");
        }

        static void S1_13() 
        {
            
        }
    }
}
