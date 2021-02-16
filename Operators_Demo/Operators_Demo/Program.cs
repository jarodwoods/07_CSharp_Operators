using System;

namespace Operators_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***Unary Operator***

            //  Increment: The ‘++’ operator is used to increment the value of an integer. 
            //  When placed before the variable name (also called pre-increment operator), its value is incremented instantly. 
            //  For example, ++x(prefix).

            //int x = 3;
            //int y = ++x;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            ////x is 4 and y is 4

            ////  And when it is placed after the variable name (also called post-increment operator), 
            ////  its value is preserved temporarily until the execution of this statement and
            ////  it gets updated before the execution of the next statement. For example, x++(postfix).

            ////   z++ is a shorthand way of typing out z = z + 1
            //int z = 10;
            //z++;
            //Console.WriteLine(z);
            ////  Outputs 11

            ////  Decrement: The ‘--‘ operator is used to decrement the value of an integer. 
            ////  When placed before the variable name (also called pre-decrement operator), 
            ////  its value is decremented instantly. For example, --x.

            //int b = 5;
            //Console.WriteLine(--b);
            ////  Outputs 4

            ////  And when it is placed after the variable name (also called post-decrement operator), 
            ////  its value is preserved temporarily until the execution of this statement and
            ////  it gets updated before the execution of the next statement. For example, x--.

            //int a = 4;
            //Console.WriteLine(a--);
            ////  Outputs 4


            //// BONUS EXAMPLE (Comment out all the lines above and below if you want to only see this example)
            //int num1 = 4;
            //Console.WriteLine($"num1++: {num1++}"); //after this statement num1 = 5
            //Console.WriteLine($"++num1: {++num1}");

            //int num2 = 4;
            //Console.WriteLine($"num2--: {num2--}"); //after this statement num2 = 3
            //Console.WriteLine($"--num2: {--num2}");
            //-----------------------------------------------------------------------------------------------------------------------

            //  Relational Operator

            //  Relational operators are used for comparison of two values.

            var number1 = 0;
            var number2 = 0;

            //  == (Equal To) operator checks whether the two given operands are equal or not. 
            //    If so, it returns true. Otherwise, it returns false. For example, 5==5 will return true.
            //if (number1 == number2)
            //{
            //    Console.WriteLine("These 2 numbers are equal to each other.");
            //}

            //  != (Not Equal To) operator checks whether the two given operands are equal or not. 
            //    If not, it returns true. Otherwise, it returns false. It is the exact boolean complement of the ‘==’ operator. 
            //    For example, 5!=5 will return false.
            //if (number1 != number2)
            //{
            //    Console.WriteLine("These 2 numbers are not equal to each other.");
            //}

            //  > (Greater Than) operator checks whether the first operand is greater than the second operand. 
            //    If so, it returns true. Otherwise, it returns false. For example, 6>5 will return true.
            //if (number1 > number2)
            //{
            //    Console.WriteLine("Number1 is greater than number 2.");
            //}

            //  < (Less Than) operator checks whether the first operand is lesser than the second operand. 
            //    If so, it returns true. Otherwise, it returns false. For example, 6<5 will return false.
            //if (number1 < number2)
            //{
            //    Console.WriteLine("Number1 is less than number2.");
            //}

            //  >= (Greater Than Equal To) operator checks whether the first operand is greater than or equal to the second operand.
            //    If so, it returns true. Otherwise, it returns false. For example, 5>=5 will return true.
            //if (number1 >= number2)
            //{
            //    Console.WriteLine("Number 1 is greater than or equal to number 2.");
            //}

            //  <= (Less Than Equal To) operator checks whether the first operand is lesser than or equal to the second operand. 
            //    If so, it returns true. Otherwise, it returns false. For example, 5<=5 will also return true.
            //if (number1 <= number2)
            //{
            //    Console.WriteLine("Number 1 is less than or equal to number 2.");
            //}

            //  Logical Operators

            //  Logical operators are used to combine two or more conditions or to complement the evaluation of the original condition in consideration.

            //  AND: The && operator returns true when both the conditions in consideration are satisfied.Otherwise, it returns false.
            //  For example, 5 == 5 && 5 > 10 returns true when both a and b are true.
            //if (number1 == number2 && number1 == 0)
            //{
            //    Console.WriteLine("Number 1 is equal to number 2 AND number 1 is equal to 0.");
            //}

            //  OR: The || operator returns true when one (or both) of the conditions in consideration is satisfied otherwise it returns false.
            //  For example, a || b returns true if  a or b is true.  And it returns true when both a and b are true.
            //if (number1 > number2 || number2 == 0)
            //{
            //    Console.WriteLine("number 1 is not greater than number 2 BUT number 2 IS EQUAL TO 0, therefore, this code gets executed.");
            //}

            //  NOT: The ! operator returns true if the condition in consideration is not satisfied.
            //  Otherwise, it returns false. For example, !a returns true if a is false. (Opposite Operator)
            //var notVariable = false;

            //if (!notVariable)
            //{
            //    Console.WriteLine("The ! operator basically does the opposite.");
            //    Console.WriteLine("And since the oposite of false is true.... this code gets executed.");
            //}

            //--------------------------------------------------------------------------------------------------------------------------

            //  Assignment Operator

            /*  Assignment operators are used to assign a value to a variable. 
                The left side operand of the assignment operator is a variable and
                the right side operand of the assignment operator is a value. 
                The value on the right side must be of the same data-type of the variable on the left side, 
                otherwise the compiler will raise an error. */

            //  = (Simple Assignment): This is the simplest assignment operator.

            //  We've been using simple assignment this whole time just look above (for example: Line 126)

            //  += (Add Assignment): This operator is a combination of ‘+’ and ‘=’ operators. 
            //      This operator first adds the current value of the variable on the left to the value on the right and 
            //      then assigns the result to the variable on the left.
            //      (a += b) same as (a = a + b) 
            //      If the initial value stored in "a" is 5 and "b" is 6. Then (a += 6) = 11.

            var stephensVariable = 10;
            var johnsVariable = 20;
            var answer = 0;

            answer += stephensVariable;   //  answer = answer + stephensVariable
            
            //Console.WriteLine(answer);


            //  -= (Subtract Assignment): This operator is a combination of ‘-‘ and ‘=’ operators. 
            //      This operator first subtracts the current value of the variable on the left from the value on the right and
            //      then assigns the result to the variable on the left.

            //      Example: a = 8 b = 6
            //      (a -= b) same as (a = a - b)  2 = 8 - 6
            //      If the initial value stored in a is 8. Then (a -= 6) = 2.

            var a1 = 433323;
            var b1 = 37747;
            var answer2 = 0;

            a1 -= b1; // a1 = a1 - b1

            //  *= (Multiply Assignment): This operator is a combination of ‘*’ and ‘=’ operators. 
            //      This operator first multiplies the current value of the variable on the left to the value on the right and
            //      then assigns the result to the variable on the left.

            //      Example:
            //      (a *= b) same as (a = a * b)
            //      If the initial value stored in a is 5. Then (a *= 6) = 30.
            var a2 = 100;
            var b2 = 50;
            var answer3 = 0;

            a2 *= b2; // a2 = a2 * b2;

            //  /= (Division Assignment): This operator is a combination of ‘/’ and ‘=’ operators. 
            //      This operator first divides the current value of the variable on the left by the value on the right and
            //      then assigns the result to the variable on the left.

            var a3 = 1000;
            var b3 = 5;
            var answer4 = 0;

            a3 /= b3; // a3 = a3 / b3
            //      Example:
            //      (a /= b) same as (a = a / b)
            //      If the initial value stored in a is 6. Then (a /= 2) = 3.

            //  %= (Modulus Assignment): This operator is a combination of ‘%’ and ‘=’ operators. 
            //      This operator first modulo the current value of the variable on the left by the value on the right and 
            //      then assigns the result to the variable on the left.
            var a4 = 22;
            var b4 = 22;
            var answer5 = 0;

            a4 %= b4; // a4 = a4 % b4;
            Console.WriteLine(a4 / b4); // 1 
            Console.WriteLine(a4 % b4); // 0
            //      Example : a = 6
            //      (a %= b) same as (a = a % b) 
            //      If the initial value stored in a is 6. Then (a %= 2) = 0.

            //-----------------------------------------------------------------------------------------------------------------------

            // Ternary Operator

            // The ternary operator, also known as the Inline-if and is syntax sugar, 
            // is a shorthand version of if-else statement. 
            // The word ternary means composed of three parts, 
            // so it makes sense that this operator has THREE operands. 
            // It will return one of two values depending on the value of a Boolean expression.


            /*                                          Syntax:
                                            condition ? trueScope : falseScope;
                 
                Explanation :
                condition: It must be evaluated to true or false.
                If the condition is true,
                trueScope is evaluated and becomes the result.
                If the condition is false,
                falseScope is evaluated and becomes the result.
                 
                 
                Example:
                var i = 1;
                var positiveMessage = (i > 0) ? "You are positive!" : "You're not positive.”;
            */
        }
    }
}
