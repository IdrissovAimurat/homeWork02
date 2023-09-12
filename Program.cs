using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task18();
            //task19();
            //task20();
            //task21();
            //task22();
            //task23();
            //task24();
            //task25();
            //task26();
            //task27();
            //task28();
            //task29();
            //task30();
            //task31();
            //task32();
            //task33();
            //task39();
            //task40();
            //task41();
            //task42();
            //task43();
        }

        /// <summary>
        /// 18.	Дана сторона квадрата. Найти его периметр.
        /// </summary>
        static void task18()
        {
            Console.Write("Введите сторону квадрата 'а': ");
            int a = Convert.ToInt32(Console.ReadLine());

            int P = a * 4;
            Console.WriteLine($"\nПериметр квадрата Р = {P} \n");
        }

        /// <summary>
        /// 19.	Дан радиус окружности. Найти ее диаметр.
        /// </summary>
        static void task19()
        {
            Console.Write("Введите сторону квадрата 'r': ");
            int r = Convert.ToInt32(Console.ReadLine());

            int d = r * 2;
            Console.WriteLine($"\nДиаметр окружности d = {d} \n");
        }

        /// <summary>
        /// 20.	Считая, что Земля — идеальная сфера с радиусом R 6350 км, 
        /// определить расстояние до линии горизонта от точки с заданной высотой над Землей.
        /// </summary>
        static void task20()
        {
            double R = 6350;


            Console.WriteLine("Введите высоту h над Землей (в км): ");
            double h = Convert.ToDouble(Console.ReadLine());


            double D = Math.Sqrt(Math.Pow(R + h, 2) - Math.Pow(R, 2));

            Console.WriteLine($"Расстояние до линии горизонта: {D} километров\n");
        }

        /// <summary>
        /// 21.	вычисления значения функции 
        ///     z=x3-2.5xy+1.78x2-2.5y+1 
        ///     при любых значениях х и y;
        /// </summary>
        static void task21()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = x * 3 - 2.5 * x * y + 1.78 * x * 2 - 2.5 * y + 1;
            Console.WriteLine($"\nz = {z}");
        }

        static void task22()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double a = (x + y) / 2;
            double d = Math.Sqrt(x * y);

            Console.WriteLine($"Среднее арифметическое = {a}, Среднее геометрическое = {d}");
        }

        /// <summary>
        /// 23.	Известны объем и масса тела. Определить плотность материала этого тела.
        /// </summary>
        static void task23()
        {
            Console.Write("Введите объем (V1) первого тела: ");
            double V1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массу (m1) первого тела: ");
            double m1 = Convert.ToInt32(Console.ReadLine());

            double p1 = m1 / V1;

            Console.WriteLine("Плотность первого тела: m1/V1: " + p1 + "\n");

            Console.Write("Введите объем (V2) первого тела: ");
            double V2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массу (m2) первого тела: ");
            double m2 = Convert.ToInt32(Console.ReadLine());

            double p2 = m2 / V2;

            Console.WriteLine("Плотность первого тела: m2/V2: " + p2 + "\n");

            if (p1 > p2)
            {
                Console.WriteLine("Плотность первого тела (р1) больше, чем второго (р2)");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Плотность второго тела (р2) больше, чем первого (р1)");
            }
            else Console.WriteLine("Они равны");
        }

        /// <summary>
        /// 24.	Составить программу обмена значениями трех переменных величин, а, b, c по следующей схеме: 
        /// a.b присвоить значение c, а присвоить значение b, с присвоить значение, а; 
        /// b.b присвоить значениe а, с присвоить значение b, а присвоить значение с.

        /// </summary>
        static void task24()
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\na)");

            int temp1 = a, temp2 = b, temp3 = c;
            b = temp3;
            a = temp2;
            c = temp1;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            Console.WriteLine("\nb)");

            b = temp1;
            c = temp2;
            a = temp3;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }

        /// <summary>
        /// 25.	Дано двузначное число. Найти: 
        /// a.число десятков в нем;
        /// b.число единиц в нем;
        /// c.сумму его цифр; 
        /// d.произведение его цифр
        /// </summary>
        static void task25()
        {
            Console.WriteLine("Write your двухзначное number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a: ");
            Console.WriteLine(number / 10);

            Console.WriteLine("b: ");
            Console.WriteLine(number % 10);

            Console.WriteLine("c: ");
            int c = (number / 10) + (number % 10);
            Console.WriteLine(c);

            Console.WriteLine("d: ");
            int d = (number / 10) * (number % 10);
            Console.WriteLine(d);
        }

        /// <summary>
        /// 26.	Дано четырехзначное число. Найти: 
        /// a.сумму его цифр; 
        /// b.произведение его цифр

        /// </summary>
        static void task26()
        {
            Console.WriteLine("Write your четырехзначное number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double a = number / 1000;
            double b = number / 100 % 10;
            double c = number / 10 % 10;
            double d = number % 10;

            Console.WriteLine($"{a}, {b}, {c}, {d}");
            Console.WriteLine("a. Сумма его цифр: " + a + b + c + d);
            Console.WriteLine("b. Произведение его цифр: " + a * b * c * d);

        }

        /// <summary>
        /// 27.	Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь:
        /// a.X или Z;
        /// b.X и Y; 
        /// c.X и Z.
        /// </summary>
        static void task27()
        {
            bool X = false;
            bool Y = true;
            bool Z = false;


            Console.WriteLine("a: X или Z");
            Console.WriteLine(X || Z);


            Console.WriteLine("\nb: X и Y");
            Console.WriteLine(X && Y);


            Console.WriteLine("\nc: X и Z");
            Console.WriteLine(X && Z);

        }

        /// <summary>
        /// 28.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь: 
        /// a.не А и В;
        /// b.А или не В;
        /// c.А и В или С.

        /// </summary>
        static void task28()
        {
            bool A = true, B = false, C = false;

            Console.WriteLine("a: не А и В");
            Console.WriteLine(!A & B);


            Console.WriteLine("\nb: А или не В");
            Console.WriteLine(A || !B);


            Console.WriteLine("\nc: А и В или С");
            Console.WriteLine(A && B || C);

        }

        /// <summary>
        /// 29.	Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: 
        /// a.	X и не (Z или Y) или не Z; 
        /// b.	не X или X и (Y или Z); 
        /// c.	(X или Y и не Z) и Z.
        /// </summary>
        static void task29()
        {
            bool X = false, Y = true, Z = false;

            Console.WriteLine("a: X и не (Z или Y) или не Z");
            Console.WriteLine(X || !(Z || Y) || !Z);


            Console.WriteLine("\nb: не X или X и (Y или Z)");
            Console.WriteLine(!X || X && (Y || Z));


            Console.WriteLine("\n(X или Y и не Z) и Z");
            Console.WriteLine((X || Y && !Z) && Z);
        }

        /// <summary>
        /// 30.	Даны два различных вещественных числа. Определить: 
        /// a.какое из них больше;        
        /// b.какое из них меньше
        /// </summary>
        static void task30()
        {
            Console.Write("Введите вещественное число 'a': ");
            String A = Console.ReadLine();

            Console.Write("Введите вещественное число 'b': ");
            String B = Console.ReadLine();

            bool isA = double.TryParse(A, out double doblA);
            bool isB = double.TryParse(B, out double doblB);

            if (isA && isB)
            {
                double temp;
                temp = doblA;

                if (doblB < temp)
                {
                    temp = doblB;
                }
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Это не вещественное число, попробуйте заново...");
            }
        }

        /// <summary>
        /// 31.	Известны два расстояния: 
        /// одно в километрах, другое — в футах ( 1 фут 0,305 м ). 
        /// Какое из расстояний меньше?
        /// </summary>
        static void task31()
        {
            Console.WriteLine("Введите расстояние S1, которое будет в футах: ");
            int S1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите расстояние S2, которое будет в километрах: ");
            int S2 = Convert.ToInt32(Console.ReadLine());

            double A1 = S1 * 0.305;
            double A2 = S2 * 1000;

            if (A1 > A2)
            {
                Console.WriteLine($"Расстояние S2, которое в километрах меньше {A2}");
            }
            else if (A1 < A2)
            {
                Console.WriteLine($"Расстояние S1, которое в футах меньше {A1}");
            }
            else Console.WriteLine($"Они равны, а потому и меньше каждый: {A1}, {A2}");

        }

        /// <summary>
        /// 32.	Дано натуральное число. 
        ///     Определить: 
        ///     a.является ли оно четным;        
        ///     b.оканчивается ли оно цифрой 7
        /// </summary>

        static void task32()
        {
            Console.Write("Введите натуральне число: ");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int a) && a > 0)
            {
                if (a % 2 == 0 && a % 7 == 0)
                {
                    Console.WriteLine("Это число четное и оканчивается на 7");
                }
                else if (a % 2 == 0 && !(a % 10 == 7))
                {
                    Console.WriteLine("Это число четное и не заканчивается на 7");
                }
                else if (!(a % 2 == 0) && a % 10 == 7)
                {
                    Console.WriteLine("Это число не четное и заканчивается на 7");
                }
                else
                    Console.WriteLine("Число не четное и не заканчивается на 7");
            }
            else
            {
                Console.WriteLine("Ты больше не армянин.");
            }
        }

        /// <summary>
        /// Дано двузначное число. Определить: 
        /// a.какая из его цифр больше: первая или вторая; 
        /// b.одинаковы ли его цифры.
        /// </summary>
        static void task33()
        {
            Console.Write("Введите двузначное число: ");
            string number = Console.ReadLine();

            if (number.Length == 2 && int.TryParse(number, out int a))
            {
                int first = a / 10;
                int second = a % 10;

                if (first > second)
                {
                    Console.WriteLine("Первая цифра больше второй.");
                }
                else if (first < second)
                {
                    Console.WriteLine("Вторая цифра больше первой.");
                }
                else
                {
                    Console.WriteLine("Цифры равны.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не двухзначное число. Ты больше не армянин");
            }
        }

        /// <summary>
        /// 39.	Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20
        /// </summary>
        static void task39()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("20 ");
            }
        }

        /// <summary>
        /// 40.	Напечатать "столбиком: 
        /// a.все целые числа от 20 до 35; 
        /// b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b больше или равно 10);
        /// c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a меньше или равно 50);
        /// d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b больше или равно a).
        /// </summary>
        static void task40()
        {
            // a. Все целые числа от 20 до 35
            Console.WriteLine("a. Все целые числа от 20 до 35:");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            // b. Квадраты всех целых чисел от 10 до b
            Console.Write("\nb. Введите значение b (b >= 10): ");
            int b = int.Parse(Console.ReadLine());
            if (b >= 10)
            {
                Console.WriteLine("Квадраты чисел от 10 до " + b + ":");
                for (int i = 10; i <= b; i++)
                {
                    int square = i * i;
                    Console.WriteLine(square);
                }
            }
            else
            {
                Console.WriteLine("b должно быть больше или равно 10");
            }

            // c. Третьи степени всех целых чисел от a до 50
            Console.Write("\nc. Введите значение a (a <= 50): ");
            int a = int.Parse(Console.ReadLine());
            if (a <= 50)
            {
                Console.WriteLine("Третьи степени чисел от " + a + " до 50:");
                for (int i = a; i <= 50; i++)
                {
                    int cube = i * i * i;
                    Console.WriteLine(cube);
                }
            }
            else
            {
                Console.WriteLine("a должно быть меньше или равно 50");
            }

            // d. Все целые числа от a до b
            Console.Write("\nd. Введите значение a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b (b >= a): ");
            b = int.Parse(Console.ReadLine());
            if (b >= a)
            {
                Console.WriteLine("Целые числа от " + a + " до " + b + ":");
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("b должно быть больше или равно a");
            }
        }

        /// <summary>
        /// 41.	Напечатать таблицу соответствия между весом в фунтах и весом 
        /// в килограммах для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г).
        /// </summary>
        static void task41()
        {
            Console.WriteLine("Фунты    Килограммы");
            for (int pounds = 1; pounds <= 10; pounds++)
            {
                double kilograms = pounds * 453.0 / 1000.0;
                Console.WriteLine($"{pounds}        {kilograms}");
            }
        }

        /// <summary>
        /// 42.	Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81
        /// </summary>
        static void task42()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"9 x {i} = {9 * i}");
            }
        }
        /// <summary>
        /// 43.	Дано натуральное число. 
        /// a.Верно ли, что сумма его цифр больше 10? 
        /// b.Верно ли, что произведение его цифр меньше 50? 
        /// c.Верно ли, что количество его цифр есть четное число? 
        /// d.Верно ли, что это число четырехзначное? Составное условие и вложенный условный оператор не использовать.
        /// e.Верно ли, что его первая цифра не превышает 6? f.Верно ли, что оно начинается и заканчивается одной и той же цифрой?
        /// g.Определить, какая из его цифр больше: первая или последняя.
        /// </summary>
        static void task43()
        {
                Console.WriteLine("Я оказывается решил уже 20 задач)) и опоздал(((((");
        }
    }
}
