using System;

namespace FirstNetCoreApp
{
    public delegate int MathOpDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
