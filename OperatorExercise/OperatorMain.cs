using System;
namespace OperatorExercise
{
    public class OperatorMain
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2; 
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2; 
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        
        public static double AreaOfCirlce(double r)
        {
            double radius = Math.PI* Math.Pow(r, 2);

            return radius; 
        }
        


    }




}


