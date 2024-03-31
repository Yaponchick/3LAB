using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LAB
{
    public class Length
    {
        private double valueN;
        private double valueZ;


        public Length(double valueN, double valueZ)
        {
            this.valueN = valueN;
            this.valueZ = valueZ;
        }

        /*
       /brief Функция для вывода.
       /return - Вывод данных.
       */
        public string Verbose()
        {
            return String.Format("{0}/{1}", this.valueN, this.valueZ);
        }

        /*
        /brief Функция для сложения.
        /param Numeretor, NumeretorTwo - операторы, которые представляют дроби.
        /return result - результат работы функции сложения.
        */
        public static Length operator +(Length Numerator, Length NumeratorTwo)
        {
            if (Numerator.valueZ == NumeratorTwo.valueZ)
            {
                double newNumerator = Numerator.valueN + NumeratorTwo.valueN;
                double newDenominator = Numerator.valueZ;

                Length result = new Length(newNumerator, newDenominator);

                return result;
            }
            else
            {
                double newNumerator1 = Numerator.valueN * NumeratorTwo.valueZ;
                double newNumerator2 = NumeratorTwo.valueN * Numerator.valueZ;
                double newDenominator = Numerator.valueZ * NumeratorTwo.valueZ;

                double newNumerator = newNumerator1 + newNumerator2;

                Length result = new Length(newNumerator, newDenominator);

                return result;
            }
        }

        /*
        /brief Функция для вычитания.
        /param Numeretor, NumeretorTwo - операторы, которые представляют дроби.
        /return result - результат работы функции вычитания.
        */
        public static Length operator -(Length Numerator, Length NumeratorTwo)
        {
            if (Numerator.valueZ == NumeratorTwo.valueZ)
            {
                double newNumerator = Numerator.valueN - NumeratorTwo.valueN;
                double newDenominator = Numerator.valueZ;

                Length result = new Length(newNumerator, newDenominator);

                return result;
            }
            else
            {
                double newNumerator1 = Numerator.valueN * NumeratorTwo.valueZ;
                double newNumerator2 = NumeratorTwo.valueN * Numerator.valueZ;
                double newDenominator = Numerator.valueZ * NumeratorTwo.valueZ;

                double newNumerator = newNumerator1 - newNumerator2;

                Length result = new Length(newNumerator, newDenominator);

                return result;
            }
        }

        /*
        /brief Функция для умножения.
        /param Numeretor, NumeretorTwo - операторы, которые представляют дроби.
        /return result - результат работы функции умножения.
        */
        public static Length operator *(Length Numerator, Length NumeratorTwo)
        {
                double newNumerator = Numerator.valueN * NumeratorTwo.valueN;
                double newDenominator = Numerator.valueZ * NumeratorTwo.valueZ;

                Length result = new Length(newNumerator, newDenominator);

                return result;
        }

        /*
        /brief Функция для деления.
        /param Numeretor, NumeretorTwo - операторы, которые представляют дроби.
        /return result - результат работы функции деления.
        */
        public static Length operator /(Length Numerator, Length NumeratorTwo)
        {
            double newNumerator = Numerator.valueN * NumeratorTwo.valueZ;
            double newDenominator = Numerator.valueZ * NumeratorTwo.valueN;

            Length result = new Length(newNumerator, newDenominator);

            return result;
        }
        /*
        /brief Функция для сравнения.
        /param lenght, lenght - операторы, которые представляют дроби.
        /return result - результат работы функции сравнения.
        */
        public static bool operator >(Length length1, Length length2)
        {
            double value1 = length1.valueN / length1.valueZ;
            double value2 = length2.valueN / length2.valueZ;

            return value1 > value2;
        }
        /*
        /brief Функция для сравнения.
        /param lenght, lenght - операторы, которые представляют дроби.
        /return result - результат работы функции сравнения.
        */
        public static bool operator <(Length length1, Length length2)
        {
            double value1 = length1.valueN / length1.valueZ;
            double value2 = length2.valueN / length2.valueZ;

            return value1 < value2;
        }
        /*
        /brief Метод для преобразования вывода.
         /param otherLength - переданная длина для сравнения.
        /return result - результат работы функции преобразования вывода.
        */
        public string To(Length otherLength)
        {
            if (this > otherLength)
                return string.Format("{0} > {1}", this.Verbose(), otherLength.Verbose());
            else if (this < otherLength)
                return string.Format("{0} < {1}", this.Verbose(), otherLength.Verbose());
            else
                return string.Format("{0} = {1}", this.Verbose(), otherLength.Verbose());
        }
        /*
        /brief Функция для сокращения.
        /return result - результат работы функции сокращения.
        */
        public string Remains()
        {
            double result = Divider(valueN, valueZ);

            valueN /= result;
            valueZ /= result;

            return $"{valueN} / {valueZ}";

        }
        /*
        /brief Функция для поиска максимального делителя.
        /param a, b - переменные для поиска максимального делителя.
        /return result - результат работы функции поиска максимального делителя.
        */
        private double Divider(double a, double b)
        {
            while (b != 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}