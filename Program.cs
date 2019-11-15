using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите дробное число X ");
            double x = Double.Parse(Console.ReadLine());
            int d;
            d = (int)(x * 10) % 10;
            Console.WriteLine(" Первая цифра после запятой числа x" + d); (1)*/

            /*Console.WriteLine("Введите количество секунд, прошедших с начала суток");
            int seconds = int.Parse(Console.ReadLine());
            int hours;
            int minutes;
            hours = seconds / 3600;
            minutes = (seconds % 3600) / 60;
            Console.WriteLine("Количество часов " + hours + " , количество минут " + minutes);   (2)*/

            /*Console.WriteLine("Часы");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Минуты");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Секунды");
            double sec = double.Parse(Console.ReadLine());
            double angle = hours * 30 + min / 2 + sec / 120;
            Console.WriteLine("Угол в градусах " + angle);  (3)*/

            /*Console.WriteLine("Введите две переменные, которые должны обменяться значениями.");
            Console.WriteLine("x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y ");
            int y = int.Parse(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Новые значения: x  " + x + ", y  " + y + ".");  (4)*/

            /*Console.WriteLine("Введите катет a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите катет b");
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double S = a * b / 2;
            double P = a + b + c;
            Console.WriteLine("Периметр равен: " + P + "  Площадь равна: " + S);  (5)*/

            /*Console.WriteLine("Введите 4-х значное число:");
            int num = int.Parse(Console.ReadLine());
            int num_1 = num / 1000;
            int num_2 = (num / 100) % 10;
            int num_3 = (num % 100) / 10;
            int num_4 = (num & 100) % 10;
            int num_5 = num_1 * num_2 * num_3 * num_4;
            Console.WriteLine("Произведение чисел: " + num_5);  (6) */

            /*Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            int num_1 = num / 100;
            int num_2 = (num / 10) % 10;
            int num_3 = num % 10;
            int reversed = num_3 + num_2 + num_1;
            Console.WriteLine("Перевернутое чисело: " + reversed); (7) */

            /*Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int y = ((3 * x + (-5)) * x + 1) * x + 7;
            Console.WriteLine(y);    (8)*/

            /*int a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, de, de_1, de_2, de_3, x, y, z;

            Console.WriteLine("Введите a1, b1, c1, d1 ");
            a1 = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            d1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a2, b2, c2, d2 ");
            a2 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            d2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a3, b3, c3, d3 ");
            a3 = int.Parse(Console.ReadLine());
            b3 = int.Parse(Console.ReadLine());
            c3 = int.Parse(Console.ReadLine());
            d3 = int.Parse(Console.ReadLine());

            de = a1 * b2 * c3 - a1 * b3 * c2 - b1 * a2 * c3 + b1 * a3 * c2 + c1 * a2 * b3 - c1 * a3 * b2;

            if (de != 0)
            {
                de_1 = d1 * b2 * c3 - d1 * b3 * c2 - b1 * d2 * c3 + b1 * d3 * c2 + c1 * d2 * b3 - c1 * d3 * b2;
                de_2 = a1 * d2 * c3 - a1 * d3 * c2 - d1 * a2 * c3 + d1 * a3 * c2 + c1 * a2 * d3 - c1 * a3 * d2;
                de_3 = a1 * b2 * d3 - a1 * b3 * d2 - b1 * a2 * d3 + b1 * a3 * d2 + d1 * a2 * b3 - d1 * a3 * b2;
                x = de_1 / de;
                y = de_2 / de;
                z = de_3 / de;
                Console.WriteLine(" x=" + x + " y=" + y + " z=" + z);
            }
            else
                Console.WriteLine("Error"); (9)*/

            /*Console.WriteLine("Введите первое наименование");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите первый тип");
            string b1 = Console.ReadLine();
            Console.WriteLine("Введите первую посевную площадь (га)");

            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую урожайность (ц/га)");
            string d1 = Console.ReadLine();

            Console.WriteLine("Введите второе наименование");
            string a2 = Console.ReadLine();
            Console.WriteLine("Введите второй тип");
            string b2 = Console.ReadLine();
            Console.WriteLine("Введите вторую посевную площадь (га)");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую урожайность (ц/га)");
            string d2 = Console.ReadLine();

            Console.WriteLine("Введите третье наименование");
            string a3 = Console.ReadLine();
            Console.WriteLine("Введите третий тип");
            string b3 = Console.ReadLine();
            Console.WriteLine("Введите третью первую посевную площадь (га)");
            int c3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью урожайность (ц/га)");
            string d3 = Console.ReadLine();


            Console.WriteLine(" ________________________________________________________________________");
            Console.WriteLine("|                     Сельскохозяйственные культуры                      |");
            Console.WriteLine("|________________________________________________________________________|");
            Console.WriteLine("|  Наименование |  Тип  |  Посевная площадь (га) |  Урожайность (ц/га)   |");
            Console.WriteLine("|________________________________________________________________________|");
            Console.Write("|{0,15}|", a1);
            Console.Write("{0,7}|", b1);
            Console.Write("{0,24}|", c1);
            Console.WriteLine("{0,23}|", d1);
            Console.WriteLine("|________________________________________________________________________|");
            Console.Write("|{0,15}|", a2);
            Console.Write("{0,7}|", b2);
            Console.Write("{0,24}|", c2);
            Console.WriteLine("{0,23}|", d1);
            Console.WriteLine("|________________________________________________________________________|");
            Console.Write("|{0,15}|", a3);
            Console.Write("{0,7}|", b3);
            Console.Write("{0,24}|", c3);
            Console.WriteLine("{0,23}|", d3);
            Console.WriteLine("|________________________________________________________________________|");    (10)*/

            /*Console.WriteLine("Для уравнений \na = 2cos(x-П/6)/1/2+sin^2y \nb = 1+z^2/3+z^2/5 \nВведите значения x,y,z");
            int x, y, z;
            double result_1, result_2;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            result_1 = 2 * Math.Cos(x - Math.PI / 6) / 1 / 2 + Math.Pow(Math.Sin(y), 2);
            Console.WriteLine($"y = " + result_1);
            result_2 = 1 + Math.Pow(z, 2) / 3 + Math.Pow(z, 2) / 5;
            Console.WriteLine($"z = " + result_2);   (11)*/
        }
    }
}
