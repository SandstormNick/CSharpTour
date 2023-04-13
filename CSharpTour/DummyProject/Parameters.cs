using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DummyProject
{
    internal class Parameters
    {
        //A reference parameter is used for passing arguments by reference.
        //The argument passed for a reference parameter must be a variable with a definite value.
        //During execution of the method, the reference parameter represents the same storage location as the argument variable.
        //A reference parameter is declared with the ref modifier. The following example shows the use of ref parameters.
        static void Swap(ref int x, ref int y)
        {
            //int temp = x;
            //x = y;
            //y = temp;
            (y, x) = (x, y);
        }

        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }



        //An output parameter is used for passing arguments by reference.
        //It's similar to a reference parameter,
        //except that it doesn't require that you explicitly assign a value to the caller-provided argument.
        //An output parameter is declared with the out modifier.
        //The following example shows the use of out parameters.
        static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }

        public static void OutUsage()
        {
            Divide(10, 3, out int quo, out int rem);
            Console.WriteLine($"{quo} {rem}");  // "3 1"
        }




        //A parameter array permits a variable number of arguments to be passed to a method.
        //A parameter array is declared with the params modifier.
        //Only the last parameter of a method can be a parameter array,
        //and the type of a parameter array must be a single-dimensional array type.
        //The Write and WriteLine methods of the System.Console class are good examples of parameter array usage.
        //They're declared as follows.

        //public class Console
        //{
        //    public static void Write(string fmt, params object[] args) { }
        //    public static void WriteLine(string fmt, params object[] args) { }
        //    // ...
        //}
    }
}
