namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Dood.
    /// Terug  naar begin, opnieuw beginnen.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class Dood: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op dood ({Positie}) en moet naar start");
            Vak start = Bord.FindVak(0);
            p.Verplaats(start);
        }
    }
}
