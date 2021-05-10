using System;

namespace Task3
{
    class Fractions
    {
        public int n; // numerator - числитель
        public int d; // denominator - знаменатель
    
    
    
    public Fractions(int N, int D)  // конструктор
        {

            if (D == 0) throw new ArgumentException("Знаменатель не может быть равен 0");

            this.n = N;
            this.d = D;
        }
    
        public static Fractions Sum(Fractions A, Fractions B)   //операция сложения дробей
        {
            return new Fractions(A.n * B.d + B.n * A.d, A.d * B.d);
        }

        public static Fractions Diff(Fractions A, Fractions B)  //операция вычитания дробей
        {
            return new Fractions(A.n * B.d - B.n * A.d, A.d * B.d);
        }

        public static Fractions Multi(Fractions A, Fractions B) //операция умножения дробей
        {
            return new Fractions(A.n * B.n , A.d * B.d);
        }

        public static Fractions Div(Fractions A, Fractions B)   //операция деления дробей
        {
            return new Fractions(A.n * B.d, A.d * B.n);
        }

        public string ToString()
        {
            return $"{n} / {d}";
        }
    }
}
