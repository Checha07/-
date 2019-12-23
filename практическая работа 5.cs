using System;

namespace практическая_работа_5
{
    class Program
    {
        private static bool flag;

        static void Main(string[] args)
        {
            int k = Convert.ToInt16(Console.ReadLine());
            int d = 0;
            for (int i=1; i<=k/2; i++)
            {
                if (k % i == 0)
                {
                    d += i;
                }
            }
            if(d==k)
            {
                 flag = true;
            }
            else
            {
                 flag = false;
            }
            if(flag==true)
            {
                Console.WriteLine(d+"  Совершенное число");
            }
            else
            {
                Console.WriteLine("Несовершенное число");
            }
            Console.ReadLine();
        }
    }
}
