namespace MikulasTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PÉLDA FELADAT
            Console.WriteLine("Üdvözöllek a mikulás segítőjében");
            Console.WriteLine("Segíts a Mikulásnak megadni, hány jó gyerek van a listán");

            int joGyerekSzama = 0;
            bool siker = false;

            while (!siker)
            {
                Console.WriteLine("Kérlek add meg a jó gyerekek számát");

                string input = Console.ReadLine();


                try
                {
                    joGyerekSzama = Convert.ToInt32(input);

                    if (joGyerekSzama < 0)
                    {
                        throw new Exception("A jó gyerek száma nem lehet negatív");
                    }siker = true;
                }
                catch (OverflowException)
                {
                    //2.147.483.647
                    Console.WriteLine("Nem létezik ennyi jó gyerek");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hiba: Csak számokat adhatsz meg");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
            Console.WriteLine($"Köszönöm! A mikulás listáján {joGyerekSzama} jó gyerek van!");
            Console.ReadLine();
            */
            /* 1. feladat
            bool szius = false;
            Console.WriteLine("Gyerek neve: ");
            string nev = Console.ReadLine();
            int ajandekokSzama = 0;

            while (!szius)
            {
                Console.WriteLine($"Hány ajándékot kapjon {nev}?");
                try
                {
                    ajandekokSzama = Convert.ToInt32(Console.ReadLine());

                    if (ajandekokSzama < 0)
                    {
                        throw new Exception("Az ajándékok száma nem lehet negatív");
                    }szius = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ennyi ajándékot semelyik gyerek nem érdemel!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Az ajándékok SZÁMÁT szám formátumban kell megadni");
                }
                catch ( Exception ex )
                {
                    Console.WriteLine( ex.Message);
                }
            }
            Console.WriteLine($"{nev} {ajandekokSzama} ajándékot fog kapni");
            */
            /* 2. feladat
            int[] raktar = { 10, 5, 0 }; //jatek; edesseg; ruha (best)
            string[] ajandekTipusok = { "Játék", "Édesség", "Ruha (best)" };
            bool asd = false; 

            while (!asd)
            {

                for (int i = 0; i < raktar.Length; i++)
                {
                    Console.WriteLine($"{ajandekTipusok[i]}: {raktar[i]} db a raktaron");
                    if (raktar[i] == 0)
                    {
                        Console.WriteLine($"Nincs elég {ajandekTipusok[i]}, töltsd fel a raktárat: ");
                        try
                        {
                            int feltoltes = Convert.ToInt32(Console.ReadLine());
                            if (feltoltes < 0)
                            {
                                throw new Exception("Nem adhatsz a raktárhoz negatív számot!");
                            }
                            raktar[i] += feltoltes;
                            Console.WriteLine("Raktár feltöltve");
                            asd = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Szám legyen!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }*/
            /*3. faladat
            Console.WriteLine("Hány gyerek kapott ajándékot?: ");
            int gyerekekszama = 0;
            bool szusi = false;
            while (!szusi)
            {
                try
                {
                    gyerekekszama = Convert.ToInt32(Console.ReadLine());
                    if (gyerekekszama <= 0)
                    {
                        throw new Exception("Valaki csak kapott ajándékot");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            int osszertek = 0;
            for (int i = 0; i < gyerekekszama; i++)
            {
                Console.WriteLine($"Mennyi az {i}. ajándék értéke?: ");
                try
                {
                    int ertek = Convert.ToInt32(Console.ReadLine());
                    if (ertek < 0)
                    {
                        throw new Exception("Az ajándék értéke nem lehet negatív");
                    }
                    osszertek += ertek;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Az ajándékok összértéke: {osszertek} Ft");
            */
            /*4. feladat
            List<(string nev, int ajandekokSzama)> ranglista = new List<(string, int)>();
            int gyerekekSzama = 0;

            while (gyerekekSzama <= 0)
            {
                try
                {
                    Console.WriteLine("Hány gyerek van a ranglistán?");
                    gyerekekSzama = Convert.ToInt32(Console.ReadLine());
                    if (gyerekekSzama <= 0)
                    {
                        throw new Exception("Legalább egy gyerek legyen a listán");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < gyerekekSzama; i++)
            {
                string gyerekNev = "";
                int gyerekAjandekokSzama = 0;

                while (string.IsNullOrEmpty(gyerekNev))
                {
                    Console.WriteLine($"Mi a {i + 1}. gyerek neve?");
                    gyerekNev = Console.ReadLine();
                    if (string.IsNullOrEmpty(gyerekNev))
                    {
                        Console.WriteLine("A név nem lehet üres!");
                    }
                }

                while (gyerekAjandekokSzama < 0)
                {
                    try
                    {
                        Console.WriteLine($"Hány ajándékot kap {gyerekNev}?");
                        gyerekAjandekokSzama = Convert.ToInt32(Console.ReadLine());
                        if (gyerekAjandekokSzama < 0)
                        {
                            throw new Exception("Az ajándékok száma nem lehet negatív!");
                        }
                        ranglista.Add((gyerekNev, gyerekAjandekokSzama));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.WriteLine("Ranglista:");
            ranglista = ranglista.OrderByDescending(g => g.ajandekokSzama).ToList();
            foreach (var item in ranglista)
            {
                Console.WriteLine($"{item.nev}: {item.ajandekokSzama} ajándék");
            }
            */
            /* 5. feladat
            int keret = 0;
            while (keret <= 0)
            {
                try
                {
                    Console.WriteLine("Mekkora keretből gazdálkodik a Mikulás?");
                    keret = Convert.ToInt32(Console.ReadLine());
                    if (keret <= 0)
                    {
                        throw new Exception("A keret nem lehet nulla vagy negatív");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int felhasznaltPenz = osszertek;

            if (felhasznaltPenz > keret)
            {
                Console.WriteLine("Túlköltekeztél! A keret nem elegendő.");
            }
            else
            {
                int maradek = keret - felhasznaltPenz;
                Console.WriteLine($"A Mikulás kerete: {keret} Ft, felhasznált összeg: {felhasznaltPenz} Ft, maradék: {maradek} Ft");
            }
            */
            /* 6. feladat
            List<string> ajandekok = new List<string> { "Játék", "Édesség", "Ruha", "Könyv" };

            if (ajandekok.Count == 0)
            {
                Console.WriteLine("Nincs ajándék a listában!");
            }
            else
            {
                Random random = new Random();
                Console.WriteLine("Ajándékok kiosztása:");
                for (int i = 0; i < ranglista.Count; i++)
                {
                    int randomIndex = random.Next(ajandekok.Count);
                    string ajandek = ajandekok[randomIndex];
                    Console.WriteLine($"{ranglista[i].nev} kap egy {ajandek}-ot.");
                    ajandekok.RemoveAt(randomIndex); // eltávolítjuk a kiosztott ajándékot
                    if (ajandekok.Count == 0) break;
                }
            }

            Console.ReadLine();
            */
        }
    }
}
