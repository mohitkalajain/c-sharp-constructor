using System;

namespace c_sharp_constructor
{
    internal class ParamConstructor
    {
        //This code creates a parameterized constructor for a ParamConstructor class. 
        //When the constructor is called, it prints "From Constructor" to the console. 

        //Param Constructor
        public int a,b;
        public ParamConstructor(int x,int y)
        {
            a = x; b = y;
        }
        static void Main(string[] args)
        {
            //Create a ParamConstructor object with two parameters
            ParamConstructor obj = new ParamConstructor(50, 20);

            //Print a message to the console
            Console.WriteLine("Parameterized Constructore Example By Mohit Kala");

            //Print a blank line to the console
            Console.WriteLine("\n");

            //Print the product of the two parameters to the console
            Console.WriteLine($"{obj.a} * {obj.b} = {obj.a * obj.b}");
        }
    }
}
