using System;
using System.Collections.Generic;
using System.Text;

namespace UltraSmart
{
    public static class Math
    {
        public static double Combinatorial(double numN,double numR)
        {
            double result;
            result = Facorials(numN) / Facorials(numR) * Facorials(numN - numR);
            return result;            
        }

        public static double CombinatorialR(double numN, double numR)
        {
            double result;
            result = Facorials(numN + numR - 1) / Facorials(numR) * Facorials(numN - 1);
            return result;
        }

        public static double Sum(double num)
        {
            double result;
            result = num * (num + 1) / 2;
            return result;
        }

        public static double Mod(double num1, double num2)
        {
            return num1 % num2;
        }

        public static double Facorials(double num)
        {
            double factor;
            factor = 1;
            for (int i = 1; i <= num; i++)
            {
                factor = factor * i;
            }
            return factor;
        }

        public static double MCD(double num1, double num2) //Algoritmo de Euclides
        {
            double iaux; //Auxiliar
            num1 = System.Math.Abs(num1); //Toma valor absoluto
            num2 = System.Math.Abs(num2);
            double i1 = System.Math.Max(num1, num1); //i1 = el más grande
            double i2 = System.Math.Min(num1, num1); //i2 = el más pequeño
            do
            {
                iaux = i2;  //Guarda Divisor
                i2 = i1 % i2; //Resto pasa a divisor
                i1 = iaux;  //Divisor pasa a dividendo
            } while (i2 != 0);
            return i1; //Ultimo resto no nulo
        }

        public static double MCM(double num1, double num2)
        {
            return (num1 / MCD(num1, num2)) * num2;
        }
    }
}
