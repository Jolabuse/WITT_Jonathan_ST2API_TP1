using System;

namespace IntroCex4
{
    class Program
    {
        static int[] AskUserForParameter()
        {
            int[] result = {-1,-1};
            do
            {
                Console.WriteLine("Please the size with the form (N,M) : ");
                var s = Console.ReadLine();
                Console.WriteLine(s[0]);
                s = s.Replace("(","");
                s = s.Replace(")","");
                Console.WriteLine(s);
                var s2 = s.Split(',');
                Console.WriteLine("(N,M)=("+s2[0]+","+s2[1]+")");
                int.TryParse(s2[0], out result[0]);
                int.TryParse(s2[1], out result[1]);
                Console.WriteLine("(N,M)=("+result[0]+","+result[1]+")");
            } while (result[0]<1 || result[0] > 10000 || result[1]<1 || result[1] > 10000);

            return result;
        }

        static void Square(int[] N)
        {
            for (int i = 0; i < N[0]; i++)
            {
                for (int j = 0; j < N[1]; j++)
                {
                    if (j == 0 || j == N[1]-1)
                    {
                        if (i == 0 || i == N[0]-1)
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
                        if (i == 0 || i == N[0]-1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            if (i%3==j%3)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Square(AskUserForParameter());
        }
    }
}