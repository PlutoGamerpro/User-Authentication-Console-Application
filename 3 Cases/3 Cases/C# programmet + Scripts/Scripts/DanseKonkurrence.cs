using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cases
{


    public class DanseKonkurrence
    {
        

        public string Navn;
        public double Points;

        public DanseKonkurrence(string navn, double points)
        {
            Navn = navn;
            Points = points;
        }

        public static DanseKonkurrence operator +(DanseKonkurrence dancer1, DanseKonkurrence dancer2)
        {
            return new DanseKonkurrence($"{dancer1.Navn} & {dancer2.Navn}", dancer1.Points + dancer2.Points);
        }

        public static void danseprogram() {

            DanseKonkurrence DANSER1;
            DanseKonkurrence DANSER2;

            Console.Write("Skriv et navn på en danser: ");
            string danser = Console.ReadLine();
            Console.Write("Hvor mange points fik danser: ");
            double points = Convert.ToDouble(Console.ReadLine());
            DANSER1 = new DanseKonkurrence(danser, points);

            Console.WriteLine("");

            Console.Write("Skriv et navn på en anden danser: ");
            danser = Console.ReadLine();
            Console.Write("Hvor mange points fik danser: ");
            points = Convert.ToDouble(Console.ReadLine());
            DANSER2 = new DanseKonkurrence(danser, points);

            DanseKonkurrence combine = DANSER1 + DANSER2;

            Console.WriteLine("Begge danser fik til sammen: " + combine.Navn + " " + combine.Points);
        


        }
    }
}

    //DanseKonkurrence score_navn_PER = new DanseKonkurrence("Hans", 5);//
    // DanseKonkurrence score_navn_MARS = new DanseKonkurrence("per", 100);



    ///   DanseKonkurrence combine = score_navn_PER + score_navn_MARS;



    // Console.WriteLine(combine.Navn + " " + combine.Points);









