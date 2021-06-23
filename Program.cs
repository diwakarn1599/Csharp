using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int var1 = 1;
             string var2 = "MyVariable: ";
             int var3 = 2;

             Console.WriteLine(var2+var1);
             Console.WriteLine(add(var1, var3));*/
            int num1, num2;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("HelloWorld");

            Operations op = new Operations();
            
            Console.WriteLine("Multiplication :"+op.multiply(num1, num2));
        }

        private static int add(int x, int y)
        {
            return x + y;
        }
    }
}
