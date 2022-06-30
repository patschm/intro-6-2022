using DierenLib.Dieren;

namespace DierenLib.Verblijven
{
    public abstract class Verblijf
    {
        private List<Dier> dieren = new List<Dier>();

        protected abstract bool Check(Dier d);
        public void SluitOp(Dier d)
        {
            if (Check(d))
            {
                dieren.Add(d);
            }
            else
            {
                Console.WriteLine($"Neee! Geen {d.GetType().Name} in een {this.GetType().Name}");
            }
        }
        public void Rammel()
        {
            foreach(Dier d in dieren)
            {
                d.MaakGeluid();
            }
        }
    }
}
