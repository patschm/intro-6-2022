namespace GetallenOptellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = Vraag5Getallen();
            int uitkomst = TelGetallenOp(nummers);
            DrukUitkomstAf(uitkomst);
        }

        static void DrukUitkomstAf(int uitkomst)
        {
            Console.WriteLine($"De uitkomst is {uitkomst}");
        }

        static int TelGetallenOp(int[] nummers)
        {
            //return nummers.Sum();
            int total = 0;
            //for(int i = 0; i < nummers.Length; i++)
            //{
            //    int item = nummers[i];
            //    total = total + item;
            //}
            foreach(int item in nummers)
            {
                total = total + item;
            }
            return total;
        }

        static int[] Vraag5Getallen()
        {
            int[] getallen = new int[5];
            for(int index = 0; index < getallen.Length; index++)
            {
                getallen[index] = VraagGetal(index + 1);
            }
            return getallen;
        }

        private static int VraagGetal(int orde)
        {
            do
            {
                Console.WriteLine($"Geef {orde}e getal");
                string sNr = Console.ReadLine();
                int nr = int.Parse(sNr);
                return nr;
            }
            while(true);
        }
    }
}