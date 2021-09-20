using System;

namespace IntroCex2
{
    class Program
    {
        static int AskUserForParameter()
        {
            var result =-1;
            do
            {
                Console.WriteLine("Please write a number and press enter : ");
                int.TryParse(Console.ReadLine(), out result);
            } while (result<0 || result > 10000);

            return result;
        }
        
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Fibonacci(int n)
        {
            long f0 = 0, f1 = 1,temp;
            Console.WriteLine("{0}\n{1}",0,1);
            for (int i = 2; i < n + 1; i++)
            {
                Console.WriteLine(f1+f0);
                temp = f0;
                f0 = f1;
                f1 = f1 + temp;
            }
        }
        
        static void PrimeNb(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if(IsPrime(i))
                    Console.WriteLine("{0} is Prime",i);
            }
        }

        static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return Factorial(n - 1)*n;
        }
        
        static void Main(string[] args)
        {
            //Fibonacci(AskUserForParameter());
            //PrimeNb(AskUserForParameter());
            //Console.WriteLine(Factorial(AskUserForParameter()));
        }
    }
}