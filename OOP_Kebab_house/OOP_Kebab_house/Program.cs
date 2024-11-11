namespace OOP_Kebab_house
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklad x = new Sklad(19 , 9, 1, 1, 10, 10); // instancovani tridy do objektu Sklad jen 1x

            Console.WriteLine(x.RekniSvojeZasoby());

        }
    }
}
