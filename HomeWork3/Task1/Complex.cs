using System;

namespace Task1
{
    class Complex // класс комплексных чисел
    {
        public double re;
        public double im;

        public Complex()    //конструктор без аргументов
        {
            im = 0;
            re = 0;
        }
        public Complex(double re, double im) //конструктор с аргументами
        {
            this.re = re;
            this.im = im;
        }
        public static Complex Sum(Complex q, Complex w) // операция сложения комплексных чисел
        {
            Complex result = new Complex();
            result.re = q.re + w.re;
            result.im = q.im + w.im;
            return result;
        }
        
        public static Complex Diff(Complex q, Complex w) // операция вычитания комплексных чисел
        {
            Complex result = new Complex();
            result.re = q.re - w.re;
            result.im = q.im - w.im;
            return result;
        }
        
        public static Complex Div(Complex q, Complex w) // операция умножения комплексных чисел
        {
            Complex result = new Complex();
            result.re = q.re * w.re - q.im * w.im;
            result.im = q.re * w.im + q.im * w.re;
            return result;
        }

        public void Print() // вывод результат операции - комплексного числа на консоль
        {
            Console.WriteLine($"{re} + {im}i");
        }


    }
}

    