namespace DobbelSpel
{
    internal class Program
    {
        static void Main()
        {
            WelkomScherm();
            Dobbelen.StartDobbelen();
            Dobbelen.StartDobbelen();
            Dobbelen.StartDobbelen();
            Dobbelen.StartDobbelen();
            Dobbelen.StartDobbelen();
            Dobbelen.StartDobbelen();
            VertrekScherm();
        }

        static void VertrekScherm()
        {
            Console.WriteLine("U gaat nu al? Wat jammer.");
        }

        static void WelkomScherm()
        {
            Console.WriteLine("Welkom bij ons superdobbelspel");
        }
    }
}