namespace DeTafels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("De tafel van 1");
            //Console.WriteLine("1 x 1 = 1");
            //Console.WriteLine("2 x 1 = 2");

            //Console.WriteLine("10 x 1 = 10");

            //Console.WriteLine("De tafel van 2");
            //Console.WriteLine("1 x 2 = 2");
            //Console.WriteLine("2 x 2 = 4");

            //Console.WriteLine("10 x 2 = 20");

            //for (int tafel = 1; tafel <= 10; tafel++)
            //{
            //    DeTafelVan(tafel);
            //}

            AlleTafelsTot(20);
        }

        static void AlleTafelsTot(int aantalTafels)
        {
            for (int tafel = 1; tafel <= aantalTafels; tafel++)
            {
                DeTafelVan(tafel);
            }
        }

        static void DeTafelVan(int tafel)
        {
            Console.WriteLine($"De tafel van {tafel}");
            for(int teller = 1; teller <= 10; teller++)
            {
                Console.WriteLine($"{teller} x {tafel} = {teller * tafel}");
            }
        }
    }
}