using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cases
{
    internal class FodboldKourrence
    {

       public static void fodbold()
        {


            Console.Write("Hvor mange afleveringer blev der lavet: ");
            int afleveringer;
           afleveringer = Convert.ToInt32(Console.ReadLine());

            string scoreddrømmeholdet;
            
            
            Console.Write("Scored drømmeholdet mål ja / nej: ");
                
                scoreddrømmeholdet = Console.ReadLine().ToLower();

          

            


            for (int i = 0; i < afleveringer; i++)
            {

                if (afleveringer >= 10)
                {
                    Console.WriteLine("High Five - Jubel!!!");
                }
                else
                {
                    Console.WriteLine("Huh!");
                }
            }

            if (afleveringer <= 0)
            {
                Console.WriteLine("Shh");
            }
            if (scoreddrømmeholdet == "ja")
            {
                Console.WriteLine("Olé olé olé");
            }
            

           

           

        }

    }
}


        




    

