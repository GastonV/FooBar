using System;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 ==0)&&(i%5==0))
                {
                    Console.WriteLine("FooBar");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Foo");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
            }
        }

    }
}
