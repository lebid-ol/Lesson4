using System.Reflection.Metadata;
using System.Text;

namespace Lesson4_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //тип данных для хранения целого числа
            int i1 = 86;

            //тип данных для хранения дроби
            double d = 2.3;

            //символьный тип данных
            char K = 'C';

            /* тип данных для хранения 
             * логических значений
             */
            bool T = true;

            /* хранений строчных
             * данных */
            string s1 = "Домашка";

            //строка форматирования: вывод переменных значений в строке
            Console.WriteLine($"{i1}; {d}; {K}; {T}; {s1}");

            int i2 = 4;
            int summa = i1 + i2;

            //конкатенация строк
            Console.WriteLine("86 + 4 =" + summa);
            int subtr = i1 - i2;
            Console.WriteLine("86 - 4 =" + subtr);
            int multi = i1 * i2;
            Console.WriteLine("86 * 4 =" + multi);
            int divid = i1 / i2;
            Console.WriteLine("86 / 4 =" + divid);

            string s2 = " от 18 августа 2024 года";
            Console.WriteLine(s1 + s2);

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.BackgroundColor = ConsoleColor.Blue;

            // Устанавливаем кодировку консоли на UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Домашка на 01.09.2024");
            Console.WriteLine();
            Console.ResetColor();

            int a,b,c;
            a = 5;
            b = 10;
            c = 15;
            var sum = a + b + c;
            Console.WriteLine("Сумма трех чисел = " + sum);
            var raznica = c - a;
            Console.WriteLine("Разница между с и а = " + raznica); ;
            var proizved = a * b;
            Console.WriteLine($"Произведение а и b = {proizved}");
            double delenie = (double)c / b;
            Console.WriteLine($"Деление с на b = {delenie}");

            double temperature = 36.6;
            string temperaturetostring = temperature.ToString();
            Console.WriteLine(temperaturetostring);

            string numberstring = "123";
            int number = int.Parse(numberstring);
            Console.WriteLine(number);

            string abcstring = "abc";
            int abcnumber;
            bool success = int.TryParse(abcstring, out abcnumber);
            Console.WriteLine(success);





        }
    }
}
