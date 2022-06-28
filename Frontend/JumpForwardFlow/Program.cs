namespace JumpForwardFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 1;

            switch(age)
            {
                case 1:
                    Console.WriteLine("Eerste jaar");
                    break;
                 case 2:
                    Console.WriteLine("Tweede");
                    break ;
                default:
                    Console.WriteLine("Iets anders");
                    break;
            }

           // bool isOuderDan18 = age >= 18;
           //bool isJongerDan65 = age < 65;
            if (age >= 18 && age < 65)
            {
              Console.WriteLine("Je mag naar binnen");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Je bent te oud");
            }
            else
            {
                Console.WriteLine("Je bent te jong");
            }

        }
        static bool ValidateAge(int leeftijd)
        {
            bool isOuderDan18 = leeftijd >= 18;
            bool isJongerDan65 = leeftijd < 65;
            return isOuderDan18 && isJongerDan65;
        }
    }
}