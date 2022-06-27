namespace Data
{
    enum DagWeek
    {
        Zondag = 1,
        Maandag,
        Dinsdag,
        Woensdag,
        Donderdag,
        Vrijdag,
        Zaterdag
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool ba = true;
            bool bb = false; ;

            bool res = ba || bb;
            Console.WriteLine(res);

            int a = 10;
            Console.WriteLine(++a);
            Console.WriteLine(a);
            int result = a + 5;

            const decimal pi = 3.14152M;
           
            {
                bool isOpen = false;
                Console.WriteLine(isOpen);
            }


            DagWeek d1 = DagWeek.Maandag;
            Console.WriteLine(d1);

            decimal f1 = 4.8M;
            Console.WriteLine(f1/10);

            char karakter = 'C'; // Literal
            char c2 = karakter;
            string name = "Patrick";
            Console.WriteLine(name);
        }
    }
}