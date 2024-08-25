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
            char c = 'C';

            /* тип данных для хранения 
             * логических значений
             */
            bool b = true;

            /* хранений строчных
             * данных */
            string s1 = "Домашка";

            //строка форматирования: вывод переменных значений в строке
            Console.WriteLine($"{i1}; {d}; {c}; {b}; {s1}");

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
        }
    }
}
