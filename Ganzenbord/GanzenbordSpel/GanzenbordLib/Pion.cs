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
            next.Actie(this);
            HuidigVak = next;       
        }
    }
}