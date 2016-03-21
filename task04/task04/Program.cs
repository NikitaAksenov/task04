using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EpamTask04
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите метод сложения\n1)Add1\n2)Add2\n3)Add3\n4)Add4\n5)Add5\nДля выхода нажмите Escape");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.WriteLine("Функция 1. Введите 2 числа через запятую");
                            string str = Console.ReadLine();
                            Calculator calc = new Calculator();
                            Console.WriteLine("Результат: {0}\nНажмите любую клавишу для продолжения", calc.Sum1(str));
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            Console.WriteLine("Функция 2. Введите числа через запятую");
                            string str = Console.ReadLine();
                            Calculator calc = new Calculator();
                            Console.WriteLine("Результат: {0}\nНажмите любую клавишу для продолжения", calc.Sum2(str));
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            Console.WriteLine("Функция 3. Введите числа через произвольный разделитель");
                            string str = Console.ReadLine();
                            Calculator calc = new Calculator();
                            Console.WriteLine("Результат: {0}\nНажмите любую клавишу для продолжения", calc.Sum3(str));
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Console.Clear();
                            Console.WriteLine("Функция 4. Введите неотрицательные числа через произвольный разделитель");
                            string str = Console.ReadLine();
                            Calculator calc = new Calculator();
                            Console.WriteLine("Результат: {0}\nНажмите любую клавишу для продолжения", calc.Sum4(str));
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Console.Clear();
                            Console.WriteLine("Функция 5. Введите неотрицательные числа через произвольный разделитель");
                            string str = Console.ReadLine();
                            Calculator calc = new Calculator();
                            Console.WriteLine("Результат: {0}\nНажмите любую клавишу для продолжения", calc.Sum5(str));
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            Console.WriteLine("Выход из программы");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Нажата неверная клавиша");
                            break;
                        }
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }

    public class Calculator
    {
        public double Sum1(string str)
        {
            CultureInfo culture = new CultureInfo("en-Us"); //устанавливаем новую культуру
            IFormatProvider provider = culture;  //устанавливаем новый региональный стандарт
            NumberStyles style = NumberStyles.Any;
            string[] str1 = str.Split(',');
            if (str1.Length != 2)
            {
                //Console.WriteLine("Количество введёных чисел не равно 2");
                throw new ArgumentException();
                //return 0;
            }
            else
            {
                double sum = 0;
                double number;
                foreach (String str2 in str1)
                {
                    bool res = Double.TryParse(str2, style, provider, out number);
                    if (res)
                        sum += number;
                    else
                        //Console.WriteLine("Неверно введён символ");
                        throw new ArgumentException();
                }
                return sum;
            }
        }

        public double Sum2(string str)
        {
            CultureInfo culture = new CultureInfo("en-Us"); //устанавливаем новую культуру
            IFormatProvider provider = culture;  //устанавливаем новый региональный стандарт
            NumberStyles style = NumberStyles.Any;
            string[] str1 = str.Split(',');
            double sum = 0;
            double number;
            foreach (String str2 in str1)
            {
                bool res = Double.TryParse(str2, style, provider, out number);
                if (res)
                    sum += number;
                else
                    //Console.WriteLine("Неверно введён символ");
                    throw new ArgumentException();
            }
            return sum;
        }
        public double Sum3(string str)
        {
            CultureInfo culture = new CultureInfo("en-Us"); //устанавливаем новую культуру
            IFormatProvider provider = culture;  //устанавливаем новый региональный стандарт
            NumberStyles style = NumberStyles.Any;
            string[] str1 = str.Split(',', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_');
            double sum = 0;
            double number;
            foreach (String str2 in str1)
            {
                bool res = Double.TryParse(str2, style, provider, out number);
                if (res)
                    sum += number;
                else
                    //Console.WriteLine("Неверно введён символ");
                    throw new ArgumentException();
            }
            return sum;
        }
        public double Sum4(string str)
        {
            CultureInfo culture = new CultureInfo("en-Us"); //устанавливаем новую культуру
            IFormatProvider provider = culture;  //устанавливаем новый региональный стандарт
            NumberStyles style = NumberStyles.Any;
            string[] str1 = str.Split(',', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_');
            double sum = 0;
            double number;
            foreach (String str2 in str1)
            {
                bool res = Double.TryParse(str2, style, provider, out number);
                if (res)
                {
                    sum += number;
                    if (number < 0)
                    {
                        //Console.WriteLine("Присутствует отрицательный символ");
                        //return 0;
                        throw new ArgumentException();
                    }
                }
                else
                    //Console.WriteLine("Неверно введён символ");
                    throw new ArgumentException();
            }
            return sum;
        }
        public double Sum5(string str)
        {
            CultureInfo culture = new CultureInfo("en-Us"); //устанавливаем новую культуру
            IFormatProvider provider = culture;  //устанавливаем новый региональный стандарт
            NumberStyles style = NumberStyles.Any;
            //string[] str1 = str.Split(',', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_');
            string pattern = (@"[\d]+([,~!@#$%^&*()_]{1,3}|$)");
            double sum = 0;
            double number;
            foreach (Match m in Regex.Matches(str, pattern))
            {
                bool res = Double.TryParse(m.Groups[0].Value, style, provider, out number);
                if (res)
                {
                    sum += number;
                    if (number < 0)
                    {
                        //Console.WriteLine("Присутствует отрицательный символ");
                        //return 0;
                        throw new ArgumentException();
                    }
                }
                else
                    //Console.WriteLine("Неверно введён символ");
                    throw new ArgumentException();
            }
            return sum;
        }
    }
}
