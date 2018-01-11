using System;
using System.Collections.Generic;
using System.Text;

namespace UltraSmart.Math
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
    }
}
