using System;


namespace ConsoleApp13
{
    class Program
    {
        static void printFib(int n)
        {
            
            UInt64 get1 = 1;
            UInt64 get2 = 1;
            UInt64 som = 0;

            for (int i = 0 ; i <= n ; i++)
            {
                som = get1 + get2;
                get1 = get2;
                get2 = som;
                
                Console.Write("{0}, ",som);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Gef het gewenste lengte : ");
            int invoer = Convert.ToInt32(Console.ReadLine());
            printFib(invoer);
        }
    }
}
