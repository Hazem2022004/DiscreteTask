using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Please Enter N1,N2");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            if (N1 == 0)
                N1++;
            if (N1 == 1)
                N1++;
            for (int i = N1; i <= N2; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();

        }
    }


}
