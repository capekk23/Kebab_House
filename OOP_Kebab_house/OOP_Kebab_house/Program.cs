namespace OOP_Kebab_house
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Sklad
            Sklad sklad = new Sklad(10, 20, 3, 400, 50, 60);
            Cheff cheff = new Cheff();

            foreach (var item in sklad.RekniVsechnyZasoby())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Stopka pred zobrazenim menicka
            Console.WriteLine("\nPress any key to vybrat si svuj kebab");
            Console.ReadKey();

            cheff.PrintMenu();
            string volba = cheff.PrijimamObjednavkuSefe();

            // You could then process the choice, for example:
            switch (volba)
            {
                case "1":   
                    Console.WriteLine("Vybrali jste si jeden klasickej");
                    break;
                case "2":
                    Console.WriteLine("Vybrali jste si jeden ananasovej");
                    break;
                case "3":
                    Console.WriteLine("Vybrali jste si vege kebab");
                    break;
                case "4":
                    Console.WriteLine("Vybrali jste si vege kebab s ananasem");
                    break;
                case "5":
                    Console.WriteLine("Vybrali jste si jen maso");
                    break;
                default:
                    Console.WriteLine("Neplatná volba!");
                    break;
            }

            string objednavka = cheff.PrijimamObjednavkuSefe();  // returne takovejhle: "1-C"
            int result = sklad.OdeberZasobu(objednavka);

            if (result == 1)
            {
                Console.WriteLine("Objednávka přijata, zásoby odečteny!");
            }
            else if (result == 0)
            {
                Console.WriteLine("Není dostatek surovin!");
            }
            else
            {
                Console.WriteLine("Neplatná volba!");
            }


            //Aby zustala konzole otevrena
            Console.WriteLine("\nPress any key to vybrat si svuj kebab");
            Console.ReadKey();
        }
    }
}
