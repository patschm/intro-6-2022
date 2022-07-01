namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Doornstruik.
    /// Terug naar 37.
    /// <see href="https://nl.wikipedia.org/wiki/Ganzenbord"/>
    /// </summary>
    public class DoornStruik : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op doornstruik ({Positie}) en moet naar vak 37 ");
            Vak v37 = Bord.FindVak(37);
            p.Verplaats(v37);
        }
    }
}
