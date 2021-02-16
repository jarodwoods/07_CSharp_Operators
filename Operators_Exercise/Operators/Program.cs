using System;
using System.Security.Cryptography.X509Certificates;

namespace Operator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 
            //Create a simple program named OperatorExercise in your repos folder 
            //to write out the results of addition, subtraction, multiplication, division operations. 

            //For division, DECLARE two integer variables called a and b.
            int a;
            int b;

            //DECLARE a third integer variable and name it quotient (the result of a division) that stores the result of the division of a and b
            int quotient;

            //DECLARE another integer variable named remainder that stores the remainder (using the % operator)
            int remainder;

            //write out the results in the following form: if a = 17 and b = 4, print the following:	
            //  --> 17/4 is 4 remainder 1

            a = 17;
            b = 4;
            quotient = a / b;
            remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Exercise 2
            AreaOfCircle(123.12);
        }

        //Exercise 2
        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }


        //bonus method --> Can you call this method? (HINT: it's almost identicle to the AreaOfCircle Method)
        public static void Something()
        {
            Console.WriteLine("This method writes out 0 - 9 to the console");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {                    
                Console.WriteLine(i);
                Console.WriteLine();
            }          
           
        } 

    }
}
