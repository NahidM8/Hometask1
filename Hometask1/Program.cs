using System;
namespace Hometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 345;
            int c = 1111;
            int x = 1111;
            int y = 12345;
            int z = 56789;
            int m = 123456;

            Console.WriteLine(((Convert.ToInt32((a + b + (c * x)) + "7")+y+z)-(Convert.ToInt32(a*b + "1"))+m-(a+b+c+x))*0.18*0.03*0.01 + (y+z));

        }
    }
}
