using GanzenbordLib.Vakken;

namespace GanzenbordLib
{
    public class Pion
    {
        public string Id { get; private set; }
        public string Naam { get; set; }
        public Vak  HuidigVak { get; set; }
        public int Positie
        {
            get 
            { 
                if (HuidigVak == null )
                {
                    return 0;
                }
                return HuidigVak.Positie; 
            }
        }
        public int VorigePositie { get; set; }
        public bool IsWinnaar { get; set; }
        public bool KanNietGooien { get; set; }
        public string Kleur { get; set; }

        public void Verplaats(Vak next)
        {
            VorigePositie = Positie;
            HuidigVak = next;    
            next.Actie(this);        
        }
        public Pion()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}