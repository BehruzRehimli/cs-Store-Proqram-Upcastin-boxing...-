using System;

namespace Dersde_12_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] arr = { new DrinkProduct(),new DairyProduct(),new DrinkProduct(),new DrinkProduct()  };
            int count=0;
            int sum = 0;

            foreach (Product p in arr)
            {
                if (p is DairyProduct)
                {
                    DairyProduct dp= (DairyProduct)p;
                    count++;
                    sum += dp.FatPercent;
                }
            }
            Console.WriteLine(sum/count);


            DrinkProduct dp1 = new DrinkProduct();
            Product pr1 = dp1;
            dp1 = (DrinkProduct)pr1;
            DairyProduct dr1 = (DairyProduct)pr1;

        }
    }
}
