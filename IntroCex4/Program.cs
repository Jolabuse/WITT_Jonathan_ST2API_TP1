using System;

namespace IntroCex4
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
            } while (result<1 || result > 10000);

            return result;
        }

        static void Square(int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (j == 0 || j == M-1)
                    {
                        if (i == 0 || i == N-1)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        if (i == 0 || i == N-1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Square(AskUserForParameter(),AskUserForParameter());
        }
    }
}