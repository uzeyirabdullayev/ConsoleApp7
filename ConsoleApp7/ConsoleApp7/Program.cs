using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            Task t1 = new Task(() =>
            {

                for (int i = 1; i < 1000000000; i++)
                {
                    if (i % 8 == 0)
                    {
                        sum = sum + i;
                        Console.WriteLine(sum);
                    }
                }

            });

            //t1.Start();
            //t1.Wait();

            Task t2 = new Task(() =>
            {
                for (int i = 1; i < 2000000000; i++)
                {
                    if (i % 11 == 0)
                    {
                        sum = sum + i;
                        Console.WriteLine(sum);
                    }
                }

            });

            //t2.Start();
            //t2.Wait();

            Task t3 = new Task(() =>
            {
                for (int i = 1; i < 1000000; i++)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            });

            //t3.Start();
            //t3.Start();

            try
            {
                Task t4 = new Task(() =>
                {
                    Parallel.For(1, 1000000, (n) =>
                    {
                        for (int i = 2; i < Math.Sqrt(n); i++)
                        {
                            if (n % 1 == 0)
                            {
                                break;
                            }
                            checked
                            {
                                sum2 += n;
                            }
                        }
                    });
                });

                t4.Start();
                t4.Wait();
                Console.WriteLine(sum2);
            }

            catch (Exception er)
            {
                Console.WriteLine(er);
            }

        }


    }

}