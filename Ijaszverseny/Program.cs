namespace Ijaszverseny
{
    internal class Program
    {
        static Random rnd = new Random();
        static int[,] jatekosokPontjai;

        static string[] jatekosokNevei(int jatekosokSzama)
        {
            string[] nevek = {
                "Anna", "Bence", "Csaba", "Dóra", "Eszter",
                "Ferenc", "Gábor", "Hanna", "István", "Judit",
                "Katalin", "László", "Márk", "Nóra", "Orsolya",
                "Péter", "Réka", "Sándor", "Tamás", "Viktória",
                "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid",
                "Emese", "Flóra", "György", "Levente", "Mihály"
            };

            string[] jatekosok = new string[jatekosokSzama];

            for (int i = 0; i < jatekosokSzama; i++)
            {
                int index = rnd.Next(0, nevek.Length);
                jatekosok[i] = nevek[index];
            }

            return jatekosok;
        }

        private static int[,] Feltoltes(int jatekosokSzama)
        {
            int[,] matrix = new int[jatekosokSzama, 5];

            for (int i = 0; i < jatekosokSzama; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(0, 26);
                }
            }

            return matrix;
        }

        static void gyoztesHirdetes(string[] jatekosok)
        {
            int maxPont = 0;
            int gyoztesIndex = 0;

            for (int i = 0; i < jatekosokPontjai.GetLength(0); i++)
            {
                int ossz = 0;

                for (int j = 0; j < jatekosokPontjai.GetLength(1); j++)
                {
                    ossz += jatekosokPontjai[i, j];
                }
                Console.WriteLine($"{jatekosok[i]} összpontszáma: {ossz}");

                if (ossz > maxPont)
                {
                    maxPont = ossz;
                    gyoztesIndex = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"A verseny győztese: {jatekosok[gyoztesIndex]}");
            Console.WriteLine($"Elért pontszáma: {maxPont}");
        }

        static void Main(string[] args)
        {
            Console.Write("Játékosok száma: ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());

            jatekosokPontjai = Feltoltes(jatekosokSzama);
            string[] jatekosok = jatekosokNevei(jatekosokSzama);

            for (int i = 0; i < jatekosokPontjai.GetLength(0); i++)
            {
                Console.Write($"Az {i + 1,2}. játékos: {jatekosok[i],-8}\t Pontjai: ");

                for (int j = 0; j < jatekosokPontjai.GetLength(1); j++)
                {
                    Console.Write($"{jatekosokPontjai[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            gyoztesHirdetes(jatekosok);
        }
    }
}
