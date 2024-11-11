namespace OOP_Kebab_house
{
    class Sklad
    {
        private int Ananas = 10;
        private int Zelenina = 11;
        private int Durum = 14;
        private int Cesnekova = 200;
        private int Bylinkova = 2;
        private int Yufka = 4;
        private List<int> SeznamSurovin = new List<int> {1, 11, 14, 200, 2, 4 };

        // jak objekt typu Sklad vznika (konstruktor)
        public Sklad(int ananas, int zelenina, int durum, int cesnekova, int bylinkova, int yufka)
        {
            Ananas = ananas;
            Zelenina = zelenina;
            Durum = durum;
            Cesnekova = cesnekova;
            Bylinkova = bylinkova;
            Yufka = yufka;   
        }
        // co objekt typu Sklad umi (metody)
        public object RekniSvojeZasoby()
        {
            return SeznamSurovin;
        }
        public int OdeberPolozku()
        {
            return Zelenina;
        }

        
    }

}
