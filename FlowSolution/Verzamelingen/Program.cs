namespace Verzamelingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SimpeleArray();
            //DeList();
           // DeDictionary();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            int tmp = stack.Pop();
            //tmp = stack.Pop();

            Console.WriteLine(stack.Count);

            Queue<string> kassa = new Queue<string>();
            kassa.Enqueue("Hallo");
            kassa.Enqueue("World");

            string sItem = kassa.Dequeue();
            Console.WriteLine(sItem);
            sItem = kassa.Dequeue();
            Console.WriteLine(sItem);
        }

        private static void DeDictionary()
        {
            Dictionary<string, int> lookupLijst = new Dictionary<string, int>();
            lookupLijst.Add("een", 11);
            lookupLijst.Add("twee", 22);

            int nr = lookupLijst["twee"];
            Console.WriteLine(nr);

            foreach(var item in lookupLijst)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }

        private static void DeList()
        {
            // DataType varNaam;
            // DataType = List<int>
            // varNaam = mijnlist
            List<int> mijnlist = new List<int>();
            mijnlist.Add(1);
            mijnlist.Add(2);
            mijnlist.Add(3);
            mijnlist.Add(4);    
            mijnlist.Add(5);    

            for(int index = 0; index < mijnlist.Count; index++)
            {
                Console.WriteLine(mijnlist[index]);
            }
            foreach (var item in mijnlist)
            {
                Console.WriteLine(item);
            }

            List<string> woorden = new List<string>();

            List<decimal> prijzen = new List<decimal>();

            List<DateTime> datums = new List<DateTime>();

            List<KipCaravan> caravans = new List<KipCaravan>();
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