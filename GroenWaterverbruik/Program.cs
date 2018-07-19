using System;

namespace GroenWaterverbruik
{
    class Program
    {
        static Double berekenVerbruiksKosten(int Vastrecht, Double Verbruikskosten, int Waterverbruik)
        {
            return (Waterverbruik * Verbruikskosten) + Vastrecht;
        }

        static void Main(string[] args)
        {
            int waterverbruik = 0;
            String invoer = "";

            Double kostenbijtar1 = 0;
            Double kostenbijtar2 = 0;

            //tarief1
            const int tar1vastrecht = 100;
            const Double tar1verbruikskosten = 0.25;

            //tarief2
            const int tar2vastrecht = 75;
            const Double tar2verbruikskosten = 0.38;

            Console.WriteLine("Bereken kosten voor waterverbruik.");
            Console.WriteLine("Geef het aantal kubieke meters water van het afgelopen jaar: ");
            invoer = Console.ReadLine();
            waterverbruik = int.Parse(invoer);

            kostenbijtar1 = berekenVerbruiksKosten(tar1vastrecht, tar1verbruikskosten, waterverbruik);
            kostenbijtar2 = berekenVerbruiksKosten(tar2vastrecht, tar2verbruikskosten, waterverbruik);

            Console.WriteLine("Kosten bij tarief 1: {0}", kostenbijtar1);
            Console.WriteLine("Kosten bij tarief 2: {0}", kostenbijtar2);
            Console.WriteLine("Kosten bij tarief 0: {0}", kostenbijtar1 < kostenbijtar2 ? kostenbijtar1 : kostenbijtar2);
        }
    }
}
