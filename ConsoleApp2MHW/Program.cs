using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2MHW
{
    internal class Program
    {
        static void task1()
        {
            int spacesCount = 0;
            char input;

            Console.WriteLine("Введите символы (для завершения введите точку):");

            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                {
                    spacesCount++;
                }
            } while (input != '.');

            Console.WriteLine($"\nКоличество пробелов: {spacesCount}");
        }

        static void task2()
        {
            Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
            string ticketNumber = Console.ReadLine();

            if (ticketNumber.Length != 6)
            {
                Console.WriteLine("Некорректный номер билета.");
                return;
            }

            int sumFirstHalf = int.Parse(ticketNumber.Substring(0, 3));
            int sumSecondHalf = int.Parse(ticketNumber.Substring(3, 3));

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Билет счастливый!");
            }
            else
            {
                Console.WriteLine("Билет не счастливый.");
            }
        }

        static void task3()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string converted = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    converted += char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    converted += char.ToLower(c);
                }
                else
                {
                    converted += c;
                }
            }

            Console.WriteLine("Преобразованная строка:");
            Console.WriteLine(converted);
        }

        static void task4()
        {
            Console.WriteLine("Введите A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void task5()
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = number / 10;
            }

            Console.WriteLine("Число, прочитанное справа налево:");
            Console.WriteLine(reversedNumber);
        }

        static void task6()
        {
            int a = 5;
            int b = 10;
            int c = 21;

            Console.WriteLine(a + "  " + b + "  " + c);
        }

        static void task7()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }

        static void task8()
        {
            Console.WriteLine("Введите расстояние в сантиметрах:");
            int distanceInCentimeters = int.Parse(Console.ReadLine());
            int meters = distanceInCentimeters / 100;

            Console.WriteLine("Полных метров: " + meters);
        }

        static void task9()
        {
            Console.WriteLine("Введите количество дней:");
            int days = int.Parse(Console.ReadLine());

            int weeks = days / 7;

            Console.WriteLine("Полных недель: " + weeks);
        }

        static void task10()
        {
            Console.WriteLine("Введите двузначное число:");
            int number = int.Parse(Console.ReadLine());

            int tens = number / 10;
            int ones = number % 10;
            int sum = tens + ones;
            int product = tens * ones;

            Console.WriteLine("Число десятков: " + tens);
            Console.WriteLine("Число единиц: " + ones);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);
        } 

        static void task11()
        {
            Console.WriteLine("Введите радиус круга:");
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата:");
            double squareSide = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * circleRadius * circleRadius;
            double squareArea = squareSide * squareSide;

            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }

        static void task12()
        {
            Console.WriteLine("Введите объем первого тела:");
            double volume1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу первого тела:");
            double mass1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем второго тела:");
            double volume2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу второго тела:");
            double mass2 = double.Parse(Console.ReadLine());

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Материал первого тела имеет большую плотность.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Материал второго тела имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }

        static void task13()
        {
            Console.WriteLine("Введите сопротивление первого участка цепи (Ом):");
            double resistance1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение на первом участке цепи (В):");
            double voltage1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сопротивление второго участка цепи (Ом):");
            double resistance2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение на втором участке цепи (В):");
            double voltage2 = double.Parse(Console.ReadLine());

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток протекает по первому участку цепи.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток протекает по второму участку цепи.");
            }
            else
            {
                Console.WriteLine("Токи равны на обоих участках цепи.");
            }
        } 

        static void task14()
        {
            Console.WriteLine("Введите порядковый номер дня недели (1-7):");
            int dayOfWeek = int.Parse(Console.ReadLine());

            string dayName = "";
            switch (dayOfWeek)
            {
                case 1:
                    dayName = "понедельник";
                    break;
                case 2:
                    dayName = "вторник";
                    break;
                case 3:
                    dayName = "среда";
                    break;
                case 4:
                    dayName = "четверг";
                    break;
                case 5:
                    dayName = "пятница";
                    break;
                case 6:
                    dayName = "суббота";
                    break;
                case 7:
                    dayName = "воскресенье";
                    break;
                default:
                    dayName = "некорректный день недели";
                    break;
            }

            Console.WriteLine($"День недели: {dayName}");
        }

        static void task15()
        {
            Console.WriteLine("Введите порядковый номер дня месяца (1-12):");
            int monthNumber = int.Parse(Console.ReadLine());

            string monthName = "";
            switch (monthNumber)
            {
                case 1:
                    monthName = "январь";
                    break;
                case 2:
                    monthName = "февраль";
                    break;
                case 3:
                    monthName = "март";
                    break;
                case 4:
                    monthName = "апрель";
                    break;
                case 5:
                    monthName = "май";
                    break;
                case 6:
                    monthName = "июнь";
                    break;
                case 7:
                    monthName = "июль";
                    break;
                case 8:
                    monthName = "август";
                    break;
                case 9:
                    monthName = "сентябрь";
                    break;
                case 10:
                    monthName = "октябрь";
                    break;
                case 11:
                    monthName = "ноябрь";
                    break;
                case 12:
                    monthName = "декабрь";
                    break;
                default:
                    monthName = "некорректный месяц";
                    break;
            }

            Console.WriteLine($"Месяц: {monthName}");
        }

        static void task16()
        {
            Console.WriteLine("Введите порядковый номер дня месяца (1-12):");
            int monthNumber = int.Parse(Console.ReadLine());

            string season = "";
            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    season = "зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "осень";
                    break;
                default:
                    season = "некорректный месяц";
                    break;
            }

            Console.WriteLine($"Время года: {season}");
        }

        static void task17()
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double y = 7 * x * x - 3 * x + 6;

            Console.WriteLine("Значение функции: " + y);
        }

        static void task18()
        {
            Console.WriteLine("Введите значение a:");
            double a = double.Parse(Console.ReadLine());

            double x = 12 * a * a + 7 * a - 16;

            Console.WriteLine("Значение функции: " + x);
        }

        static void task19()
        {
            Console.WriteLine("Введите сторону квадрата (см):");
            double side = double.Parse(Console.ReadLine());

            double perimeter = 4 * side;

            Console.WriteLine("Периметр квадрата: " + perimeter + " см");
        }

        static void task20()
        {
            Console.WriteLine("Введите радиус окружности (см):");
            double radius = double.Parse(Console.ReadLine());

            double diameter = 2 * radius;

            Console.WriteLine("Диаметр окружности: " + diameter + " см");
        }
        static void Main(string[] args)
        {
            task20();
            Console.ReadKey();
        }

    }
}

        