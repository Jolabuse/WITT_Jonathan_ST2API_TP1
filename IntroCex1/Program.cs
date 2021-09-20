using System;

namespace IntroC
{
    class Program
    {
        static void MultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Table of {0}",i);
                    for (int j = 1; j < 10; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.WriteLine("{0} * {1} = {2}",i,j,i*j);
                        }
                    }
                }
                    
            }
        }

        static void MultiplicationTable(int n)
        {
            Console.WriteLine("Table of {0}",n);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} *  {1} = {2}",n,i,n*i);
            }
        }
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
        
        static void Main(string[] args)
        {
            MultiplicationTable(AskUserForParameter());
        }
    }
}
