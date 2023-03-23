namespace FilmBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Free or VIP - ");
            string choose=Console.ReadLine();

            
            if (choose == "Free")
            {
                Console.WriteLine("Choose film janr: Documentary, Comedy, Action, Drama, Thriller, Romantic");
                Console.Write("Enter film janr - ");
                string choosefilm = Console.ReadLine();
                Janrs film2 = new Film(choosefilm);
                film2.print_film_year(choosefilm);
                Console.Write("Set Star - ");
                int star = int.Parse(Console.ReadLine());
            }

            else if (choose == "VIP") { 
                Console.WriteLine("Choose film janr: Documentary, Comedy, Action, Drama, Thriller, Romantic");
                Console.Write("Enter film janr - ");
                string choosefilm = Console.ReadLine();
                Janrs film2 = new Paid(choosefilm);
                film2.print_film_year(choosefilm);
                film2.PrintCost();
                Console.Write("Set Star - ");
                int star = int.Parse(Console.ReadLine());
            }
        }
    }
}