namespace Lesson3Ex  //Гаврилов Владимир
{            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

    class ComplexClass
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - this.im;
            x3.re = x2.re - this.re;
            return x3;
        }
        public string ToStringComplex()
        {
            return re + "+" + im + "i";
        }



    }
}
