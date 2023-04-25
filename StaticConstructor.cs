using System;

namespace c_sharp_constructor
{
    /// <summary>
    /// 
    /// Use of static constructor   is used to be called before any static member of class is called . 
    /// Execution Steps
    /// 1. Static Consructor will call first
    /// 2. Data function will call
    /// 
    /// </summary>
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor");
        }
        //This code defines a public static method called Data. 
        //When the method is called, it prints the string "Called From Data Function/Method" to the console. 
        public static void Data()
        {
            Console.WriteLine("Called From Data Function/Method");
        }
        public static void Main(string[] args)
        {
            StaticConstructor.Data();
        }
    }
}
