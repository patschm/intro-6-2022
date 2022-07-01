using GanzenbordLib.Vakken;

namespace GanzenbordLib
{
    public class Pion
    {
        public string Naam { get; set; }
        public Vak  HuidigVak { get; set; }
        public bool IsWinnaar { get; set; }
        public bool KanBewegen { get; set; }

        public void Verplaats(Vak next)
        {
            int pos = 0;
            if (HuidigVak != null) pos = HuidigVak.Positie;
            Console.WriteLine($"{Naam} komt van positie {pos}.");
            HuidigVak = next;    
            next.Actie(this);        
        }
    }
}