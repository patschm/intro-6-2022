namespace JumpBackFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // Gebruik deze voor bijv user invoer te valideren en hervragen.
            // Wordt 1 of meer keer uitgevoerd.
            do
            {
                Console.WriteLine("Geef een getal groter dan 10");
                counter = int.Parse(Console.ReadLine());
            }
            while (counter < 10);

            // Gebruik je om data uit te lezen (tabel, file)
            // Wordt 0 of vaker uitgevoerd
            while (counter < 10)
            {
                Console.WriteLine("Counter = " + counter);
                counter++;
            }

            //int teller = 0;
            // Je weet hoe vaak je iets moet herhalen
            for (int teller = 0; teller < 10 ;teller++)
            {
                Console.WriteLine("Loop " + teller);
            }
        }
    }
}