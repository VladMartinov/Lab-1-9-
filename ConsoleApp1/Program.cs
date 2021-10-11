using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1 - й Номер");
            Console.WriteLine("Введите значение А");
            double a;
            a = double.Parse(Console.ReadLine());
            a = a * 10;
            int D = (int)a;
            D = D % 10;
            Console.WriteLine(D);
            Console.WriteLine("2 - й Номер");
            int hour, min, sec;
            Console.WriteLine("Введите значение Секунд");
            sec = int.Parse(Console.ReadLine());
            hour = sec / 3600;
            min = (sec % 3600) / 60;
            sec = (sec % 3600) % 60;

            Console.WriteLine("Час(ов):" +hour +" Минут:"+ min) ;
            Console.WriteLine("3 - й Номер");
            int h, m, s;
            Console.WriteLine("Введите кол-во часов");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во минут");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во секунд");
            s = int.Parse(Console.ReadLine());

            if (h > 11 | h < 0 | m < 0 | m > 60 | s < 0 | s > 60)
            {
                Console.WriteLine("Введены неккоректные данные");
                    }
            else
            {
                double u, zz;
                zz = h + m / 60 + s / 3600;
                u = zz / 12 * 360;
                Console.WriteLine("Угол=" + u, " градусов");
            }

            Console.WriteLine("4 - й Номер");
            Console.WriteLine("Введите 1-е число J");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-е число K");
            int k = int.Parse(Console.ReadLine());

            j = j + k;
            k = k - j;
            k = -k;
            j = j - k;
            Console.WriteLine("Число J:" + j) ;
            Console.WriteLine("Число k:" + k);
            Console.WriteLine("5 - й Номер");
            double AB, AC, BC, S, P;
            Console.WriteLine("Введите AB");
            AB = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите AB");
            AC = double.Parse(Console.ReadLine());
            BC = Math.Sqrt((AB*AB) + (AC*AC));
            S = (AB * AC) / 2;
            P = AB + AC + BC;
            Console.WriteLine("Площадь треугольника: " + S);
            Console.WriteLine("Периметр треугольника: " + P);
            Console.WriteLine("6 - й Номер");
            var n = 1234;
            var prod = 1;
            do prod *= n % 10;
            while ((n /= 10) > 0);
            Console.WriteLine(prod);
            Console.WriteLine("7 - й Номер");
            Console.WriteLine("Введите число");
            int g = int.Parse(Console.ReadLine());
            Console.Write("{0} -> ", g);

            int r = g % 10;
            while ((g /= 10) != 0) r = r * 10 + g % 10;

            Console.WriteLine("{0}", r);
            Console.WriteLine("8 - й Номер");
            Console.WriteLine("Введите x для неравенста 3x^4-5x^3+2x^2-x+7");
            int xx,l ; //l это решение этого многочлена
            xx = 1; //Можно ввести любое X
            l = (((3 * xx - 5) * xx + 2) * xx - 1) * xx + 7; //По теореме Горнера можно свернуть в формулу где есть только 4 упножения и 4 сложения/вычитания
            Console.WriteLine("Ответ: " +l);
            Console.WriteLine("9 - й Номер");
            double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, x, y, z;
            Console.WriteLine("Заполните матрицу:");
            Console.WriteLine("a1 = ");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("a2 = ");
            a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("a3 = ");
            a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("b1 = ");
            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("b2 = ");
            b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("b3 = ");
            b3 = double.Parse(Console.ReadLine());

            Console.WriteLine("c1 = ");
            c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("c2 = ");
            c2 = double.Parse(Console.ReadLine());

            Console.WriteLine("c3 = ");
            c3 = double.Parse(Console.ReadLine());

            Console.WriteLine("d1 = ");
            d1 = double.Parse(Console.ReadLine());

            Console.WriteLine("d2 = ");
            d2 = double.Parse(Console.ReadLine());

            Console.WriteLine("d3 = ");
            d3 = double.Parse(Console.ReadLine());

            double delta = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
            double delta1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
            double delta2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
            double delta3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;

            if (delta != 0)
            {
                x = delta1 / delta;
                y = delta2 / delta;
                z = delta3 / delta;
                Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
            }
            else Console.WriteLine("Ошибка. Определитель равен нулю.");


        }



    }


}
