/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_and_Assignment_Operators
{
    class Program
    {
        static void Main()
        {
            // Basic Arithmetic Examples
            int a = 5;
            int b = 8;
            int c = b + a;  // =13  Addition
            int d = b - a;  // =3   Subtraction
            int e = b * a;  // =40  Multiplication
            int f = b / a;  // =1   Division. Integers are rounded down when dividing.
            int g = b % a;  // =3   Modulus. Equals the remainder from division.
            // Assignment Operators
            int h = g;      // =3   Assignment. h is equal to g. (h = 3)
            h += g;         // =6   Add AND Assign. h is equal to h + g. (h = 3 + 3)
            g -= f;         // =2   Subtract AND Assign. g is equal to g - f. (g = 3 - 1)
            f *= e;         // =40  Multiply AND Assign. f is equal to f * e. (f = 1  * 40)
            e /= a;         // =8   Divide AND Assign. e is equal to e / a. (e = 40 / 5)
            c %= a;         // =3   Modulo AND Assign. c is equal to c % a. (c = 13 % 5)
        }
    }
}
