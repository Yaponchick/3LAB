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


        public string Verbose()
        {
            return String.Format("{0}/{1}", this.valueN, this.valueZ);
        }



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
        public static Length operator *(Length Numerator, Length NumeratorTwo)
        {
                double newNumerator = Numerator.valueN * NumeratorTwo.valueN;
                double newDenominator = Numerator.valueZ * NumeratorTwo.valueZ;

                Length result = new Length(newNumerator, newDenominator);

                return result;
        }
        public static Length operator /(Length Numerator, Length NumeratorTwo)
        {
            double newNumerator = Numerator.valueN * NumeratorTwo.valueZ;
            double newDenominator = Numerator.valueZ * NumeratorTwo.valueN;

            Length result = new Length(newNumerator, newDenominator);

            return result;
        }












        //Сокращение
        public void Remains()
        {
            // Находим наибольший общий делитель числителя и знаменателя
            double result = Divider(valueN, valueZ);

            // Делим числитель и знаменатель на НОД
            valueN /= result;
            valueZ /= result;
        }

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










