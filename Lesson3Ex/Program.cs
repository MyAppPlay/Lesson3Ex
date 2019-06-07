using System;

namespace Lesson3Ex   //Гаврилов Владимир
{
    //1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Minus(Complex x) //Добавлен метод Вычитания комплексных чисел.
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToStringComplex()
        {
            return re + "+" + im + "i";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            Complex complex5;
            complex5.re = 5;
            complex5.im = 5;

            Complex complex8;
            complex8.re = 8;
            complex8.im = 8;

            Complex result = complex8.Minus(complex5);
            Console.WriteLine(result.ToStringComplex());  //Демонстрация работы структуры

            Complex complex1 = new Complex();
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 2;

            Complex result2 = complex1.Plus(complex2);
            Console.WriteLine(result.ToStringComplex());
            #endregion

            #region Ex2
            //а)  С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            //    Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            int a = 1;
            int b = 1;
            int sum = 0;
            string rezult = " ";
            for (a = 1; b != 0; a++)
            {
                b = int.Parse(Console.ReadLine());
                if (b % 2 != 0)
                {
                    sum = sum + b;
                    rezult = rezult + " " + b;
                }
            }
            Console.WriteLine("нечетные числа - " + rezult + "  их сумма " + sum);
            #endregion

            Console.ReadKey();
        }


    }
}
