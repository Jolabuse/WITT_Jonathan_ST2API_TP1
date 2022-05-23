using System;

namespace IntroCex5
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
            } while (result<3 || result > 20);

            return result;
        }

        
        static void ChristmasTree(int n)
        {
            var rand = new Random();
            var cptI = 0;
            var cptO = 0;
            for (var i = 1; i < n+1; i++)
            {
                for (var j = 0; j < ((n*2-1)-(i*2-1))/2; j++)
                {
                    Console.Write(" ");
                }

                for (var j = 0; j < i*2-1; j++)
                {
                    switch ((i*2-1)%3)
                    {
                        case 0:
                            if (j%3==0)
                            {
                                if (cptO < cptI - 1)
                                {
                                    if (rand.Next(2)==0)
                                    {
                                        cptO++;
                                        Console.Write("o");
                                    }
                                    else
                                    {
                                        cptI++;
                                        Console.Write("i");
                                    }
                                }
                                else
                                {
                                    cptI++;
                                    Console.Write("i");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }

                            break;
                        case 1:
                            if (j%3==1)
                            {
                                if (cptO < cptI - 1)
                                {
                                    if (rand.Next(2)==0)
                                    {
                                        cptO++;
                                        Console.Write("o");
                                    }
                                    else
                                    {
                                        cptI++;
                                        Console.Write("i");
                                    }
                                }
                                else
                                {
                                    cptI++;
                                    Console.Write("i");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }

                            break;
                        case 2:
                            if (j%3==2)
                            {
                                if (cptO < cptI - 1)
                                {
                                    if (rand.Next(2)==0)
                                    {
                                        cptO++;
                                        Console.Write("o");
                                    }
                                    else
                                    {
                                        cptI++;
                                        Console.Write("i");
                                    }
                                }
                                else
                                {
                                    cptI++;
                                    Console.Write("i");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }

                            break;
                    }
                    
                }
                //Console.Write((((n*2-1)-(i*2-1))/2).ToString()+"-"+(i*2-1).ToString()+"-"+(((n*2-1)-(i*2-1))/2).ToString());
                Console.WriteLine();
            }

            for (var i = 0; i < n-2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("| |");
        }
        
        static void Main(string[] args)
        {
            ChristmasTree(AskUserForParameter());
        }
    }
}