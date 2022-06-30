using DierenLib.Verblijven;

namespace DierenLib
{
    public class Dierentuin
    {
        private List<Verblijf> verblijven = new List<Verblijf>();

        public void Open()
        {
            foreach(Verblijf v in verblijven)
            {
                v.Rammel();
            }
        }
        public void VoegToe(Verblijf v)
        {
            verblijven.Add(v);
        }
    }
}
