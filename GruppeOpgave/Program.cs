namespace GruppeOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("""
                Kvittering
                -----------------------
                """);
            Produkt("Seng", 200);
            Produkt("Bord", 300);
            Produkt("Stol", 450);
            Console.WriteLine("""

                Sum
                -----------------------
                """);
            Sum(200, 300, 450);


        }



        public static void PrintStylish(string text, int timer)
        {
            foreach (char c in text)
            {

                Console.Write(c);
                Thread.Sleep(timer);
            }
            Console.WriteLine();
        }
        public static void Produkt(string produktNavn, int pris)
        {
            PrintStylish($"{produktNavn} - Pris u/moms: {pris:C2} - Pris m/moms: {pris * 1.25:C2}", 25);
        }

        public static void Sum(int x, int z, int y)
        {
            PrintStylish($"Uden moms: {x + z + y:C2} - Med moms: {(x + z + y) * 1.25:C2}", 25);
        }

    }
}
