namespace Verzamelingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpeleArray();
        }

        static void SimpeleArray()
        {
            int[] kluisjes = new int[5]; // Hier maak ik het kluisje.
            kluisjes[3] = 42;  // Vullen
            kluisjes[1] = 10;

            int inhoud = kluisjes[3];  // Uitlezen
            Console.WriteLine(inhoud);

            string[] woorden = new string[10];
            woorden[7] = "Hallo";

            string sInhoud = woorden[7];
            Console.WriteLine(sInhoud);


            decimal[] prijzen = new decimal[8];
            prijzen[3] = 8.71M;

            DateTime[] data = new DateTime[20];
            data[6] = DateTime.Now;

            DateTime elem = data[6];
            Console.WriteLine(elem);

            int[] nummers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(nummers[6]);

            int[] nummers2 = new int[11];
            Array.Copy(nummers, nummers2, nummers.Length);
            nummers2[10] = 15;

            for(int index = 0; index < nummers2.Length; index++)
            {
                int tmp = nummers2[index];
                Console.WriteLine(tmp);
                //Console.WriteLine($"[{index}] = {nummers2[index]}");
            }
            Console.WriteLine("=== foreach ====");
            foreach(int tmp in nummers2)
            {
                Console.WriteLine(tmp);
            }

        }
    }
}