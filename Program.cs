using System;

namespace Taxopark
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice=1;
            while (Choice!=0)
            {
                
                Taxopark taxopark = new Taxopark();
                Console.WriteLine("1- Cost Taxopark\n2-Fuel Sort \n3-Range Speed ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            double cost= taxopark.CostTaxopark();
                            Console.WriteLine($"Cost Taxopark = {cost}");
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            taxopark.SortTaxopark();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine($"range of speed ");
                            Console.WriteLine("Min: ");
                            int MinSpeed = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Max: ");
                            int MaxSpeed = Convert.ToInt32(Console.ReadLine());
                            taxopark.OutputNeedSpeed(MinSpeed, MaxSpeed);
                            Console.WriteLine("\n");
                            break;
                        }


                }
            }
        }
    }
}
