using System.ComponentModel.Design;

namespace Lesson4_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка возраста
            /*Попросите пользователя ввести свой возраст с помощью Console.ReadLine().
             Используя int.TryParse(), проверьте, корректно ли введен возраст.
             Если введенное значение не является числом, выведите сообщение об ошибке.
             Если число введено правильно:
             Если возраст меньше 18, выведите "Вы несовершеннолетний".
             Если возраст от 18 до 65, выведите "Вы трудоспособный человек".
             Если возраст больше 65, выведите "Вы пенсионер".*/

            Console.WriteLine("Введите свой возраст: ");
            var age = Console.ReadLine();
            bool resultParse = int.TryParse(age, out int true_age);
            if (resultParse == false)
            {
                Console.WriteLine("Возраст введен неверно. Значение не является числом");
            }
            else
            {
                if (true_age < 18)
                {
                    Console.WriteLine("Вы несовершеннолетний");
                }
                else if (true_age >= 18 && true_age <= 65)
                {
                    Console.WriteLine("Вы трудоспособный человек");
                }
                else if (true_age > 65)
                {
                    Console.WriteLine("Вы пенсионер");
                }
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            
            //Задание 2: Калькулятор с использованием switch

            /*Попросите пользователя ввести два числа.
            Попросите пользователя выбрать одну из операций: сложение, вычитание, умножение или деление.
            Используя switch, выполните соответствующую операцию и выведите результат.
            Если операция не распознана, выведите сообщение об ошибке.*/

            Console.WriteLine("Введите два числа");

            bool firstinput = false, secondinput = false;
            double firstnumber, secondnumber;

            //while (!firstinput)
            //{
                Console.WriteLine("Введите первое число:");
                firstinput = double.TryParse(Console.ReadLine(), out firstnumber);
                if (firstinput == false)
                {
                    Console.WriteLine("Первое число введено некорректно. Введите числовое значение. Если число дробное, используйте запятую");
                }
            //}

            //while (!secondinput)
            //{
                Console.WriteLine("Введите второе число:");
                secondinput = double.TryParse(Console.ReadLine(), out secondnumber);
                if (secondinput == false)
                {
                    Console.WriteLine("Второе число введено некорректно.Введите числовое значение. Если число дробное, используйте запятую");
                }
            //}

            Console.WriteLine("Выберете одну из операций: сложение, вычитание, умножение или деление");
            Console.WriteLine("Для выбора сложения нажмите - 1, вычитания - 2, умножения -3, деления - 4");

            bool resultinput = int.TryParse(Console.ReadLine(), out int result);
            if (resultinput == false)
            {
                while (!resultinput)
                {
                    Console.WriteLine("Данные некорретны. Введите числовое значение:");
                    resultinput = int.TryParse(Console.ReadLine(), out result);
                }
            }
           
            switch (result)
            {
                case 1: Console.WriteLine($"Результат сложение: {firstnumber + secondnumber}"); break;
                case 2: Console.WriteLine($"Результат вычитания: {firstnumber - secondnumber}"); break;
                case 3: Console.WriteLine($"Результат умножения: {firstnumber * secondnumber}"); break;
                case 4:
                    if (secondnumber != 0)
                    {
                        Console.WriteLine($"Результат деления: {firstnumber / secondnumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Деление на ноль неовозможно");
                    }
                    break;

                        default:
                    Console.WriteLine("Операция не выбрана. Нажмите 1, 2, 3 или 4 для нужной операции");
                    break;
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            /*Задание 3: Работа с массивом
            Создайте массив на 5 элементов типа int.
            Инициализируйте каждый элемент массива с помощью индексов.
            Выведите все значения массива на экран.
            БЕЗ ЦИКЛА. ТОЛЬКО ИНДЕКСЫ*/

            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine($"Элементы массива: {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}");

        }

            }
    }


