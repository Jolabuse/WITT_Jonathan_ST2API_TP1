using System;

namespace IntroCex3
{
    class Program
    {
        private static int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }

        static void Divide10()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10/PowerFunction(i));
                }
                catch
                {
                    Console.WriteLine("Error for {0}",i);
                }
            }
        }
        
        static void Main(string[] args)
        {
            Divide10();
        }
    }
}