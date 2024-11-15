namespace OOP_Kebab_house
{
    class Cheff
    {
        // jak objekt typu Cheff vznika (konstruktor)
        public Cheff()
        {
            
        }
        public string PrintMenu()
        {
            string obsahSouboru = File.ReadAllText(@"menu.txt"); // @ vypina specialni znaky
            Console.WriteLine(obsahSouboru);
            return obsahSouboru;
        }

        public string PrijimamObjednavkuSefe()
        {
            Console.WriteLine("Vyber si svoje menu - (napis 1 - 5)");
            string vyber = Console.ReadLine();

            Console.WriteLine("Česneková nebo bylinková omáčka? (C/B)");
            string omacka = Console.ReadLine().ToUpper();  // Convert to uppercase to handle both "c" and "C"

            // Combine menu choice with sauce choice
            return $"{vyber}-{omacka}";  // This will return something like "1-C" or "2-B"
        }
    }
}
