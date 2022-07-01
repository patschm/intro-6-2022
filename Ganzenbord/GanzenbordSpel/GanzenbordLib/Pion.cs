using GanzenbordLib.Vakken;

namespace GanzenbordLib
{
    public class Pion
    {
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
        public bool BeurtOverslaan { get; set; }

        public void Verplaats(Vak next)
        {
            Console.WriteLine($"{Naam} komt van positie {Positie}.");
            VorigePositie = Positie;
            HuidigVak = next;    
            next.Actie(this);        
        }
    }
}