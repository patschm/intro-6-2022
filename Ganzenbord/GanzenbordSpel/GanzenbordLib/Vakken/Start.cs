namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Start.
    /// Het startpunt van het spel.
    /// </summary>
    public class Start : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} is aangemeld op Start (0)");
        }
    }
}
