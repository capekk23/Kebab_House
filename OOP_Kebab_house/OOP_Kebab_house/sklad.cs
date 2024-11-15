namespace OOP_Kebab_house
{
    class Sklad
    {

        Dictionary<string, int> SkladDict = new Dictionary<string, int>()
            {
                { "Ananas", 95 },
                { "Zelenina", 87 },
                { "Durum", 92 },
                { "Cesnekova", 34 },
                { "Bylinkova", 1000 },
                { "Yufka", 4 }
            };

        // jak objekt typu Sklad vznika (konstruktor)
        public Sklad(int ananas, int zelenina, int durum, int cesnekova, int bylinkova, int yufka)
        {
            SkladDict["Ananas"] = ananas;
            SkladDict["Zelenina"] = zelenina;
            SkladDict["Durum"] = durum;
            SkladDict["Cesnekova"] = cesnekova;
            SkladDict["Bylinkova"] = bylinkova;
            SkladDict["Yufka"] = yufka;
        }

        public int OdeberZasobu(string objednavka)
        {
            string[] parts = objednavka.Split('-');  // Split "1-C" na ["1", "C"]
            string menu = parts[0];
            string omacka = parts[1];

            // prvni omacka
            string sauceType = omacka == "C" ? "Cesnekova" : "Bylinkova";
            if (SkladDict[sauceType] <= 0)
            {
                return 0;  // neni omacka uz
            }

            switch (menu)
            {
                case "1":
                    if (SkladDict["Zelenina"] > 0 && SkladDict["Durum"] > 0 && SkladDict["Yufka"] > 0)
                    {
                        SkladDict["Zelenina"]--;
                        SkladDict["Durum"]--;
                        SkladDict["Yufka"]--;
                        SkladDict[sauceType]--;  // remove chosen sauce
                        return 1;
                    }
                    return 0;

                case "2":
                    if (SkladDict["Zelenina"] > 0 && SkladDict["Yufka"] > 0)
                    {
                        SkladDict["Zelenina"]--;
                        SkladDict["Yufka"]--;
                        SkladDict[sauceType]--;
                        return 1;
                    }
                    return 0;

                // Add more cases as needed

                default:
                    return -1;
            }
        }

        public Dictionary<string, int> RekniVsechnyZasoby()
        {
            return SkladDict;
        }

    }
}   
