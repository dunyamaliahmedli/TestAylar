using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;


            for (int i = m; i <= n; i++)
            {
                if (i % 7 == 0&& i!=0)  
                {
                    count++;
                }

                   
                        
            }
            Console.WriteLine(count);
        }
    }
}
