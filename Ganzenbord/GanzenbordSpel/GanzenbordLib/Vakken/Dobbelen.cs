namespace GanzenbordLib.Vakken
{
    /// <summary>
    /// Dobbelen.
    /// Speler mag nog een keer dobbelen.
    /// </summary>
    public class Dobbelen: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} mag opnieuw gooien  ({Positie})");
            int worp = Bord.WerpStenen();
            Vak vnext = Bord.FindVak(Positie + worp);
            p.Verplaats(vnext);
        }
    }
}
