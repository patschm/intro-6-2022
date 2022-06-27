namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef getal A");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);

            Console.WriteLine("Geef getal B");
            string sb = Console.ReadLine();
            decimal b = decimal.Parse(sb);
            decimal ans = a + b;

            Console.WriteLine("Wat zou de uitkomst van de optelling moeten zijn?");
            string answer = Console.ReadLine();

            Console.WriteLine($"Uw antwoord is: {answer}. Het antwoord had moeten zijn: {ans}");
        }
    }
}