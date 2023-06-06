using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_Package
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instruction bellow.");
            Console.WriteLine("Please inter your package weight here:");
            int packWieght = Convert.ToInt32(Console.ReadLine());

            if (packWieght > 50)
            {
                Console.WriteLine("Sorry, your package weight is too heavey to be shipped by Express.");


            }
            else if (packWieght < 50)
            {
                Console.WriteLine("Please inter  your package weight:");
                int packWiedht = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please inter your package hieght:");
                int packHieght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please inter the package lenth:");
                int packLenth = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(packWiedht) + Convert.ToInt32(packHieght) + Convert.ToInt32(packLenth) > 50)
                {
                    Console.WriteLine("Sorry,it is too big to be shipped.");
                    //Program ends here if the box dimention total is more than 50.
                }
                else
                {
                    Console.WriteLine("The Shipping fee that you should pay is:");

                    int ShippingFee = Convert.ToInt32(packWiedht) * Convert.ToInt32(packHieght) * Convert.ToInt32(packLenth) * Convert.ToInt32(packWieght) / 100;
                    Console.WriteLine(ShippingFee);


                }

                Console.WriteLine("Thanks enjoy from your journey!");
            }
            Console.ReadLine();

        }
    }
}
