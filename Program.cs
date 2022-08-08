using System;

namespace _08082022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //int i = 1;

            //while (i < 10)
            //{
            //    sum += i;
            //    i++;
            //}

            for(int i = 1; i < 10; i++)
            {
                sum += i;
            }
          
            Console.WriteLine(sum);

            Console.WriteLine("===================");
            int n = 71;
            int m = 76;


            bool hasNumberDividedBy7 = false;
            while (n<m)
            {
                if (n % 7 == 0)
                {
                    hasNumberDividedBy7 = true;
                    break;
                }

                n++;
            }


            if (hasNumberDividedBy7==true)
            {
                Console.WriteLine("Var");
            }
            else
            {
                Console.WriteLine("Yoxdur");
            }











        }
    }
}
