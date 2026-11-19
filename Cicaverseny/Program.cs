namespace Cicaverseny
{
    internal class Program
    {
        static Random r = new Random();

        static int[,] cicakpontjai;

        static string[] CicakNevei(int cicakSzama)
        {
            string[] nevek = {
                    "Mici", "Cirmi", "Foltos", "Morzsi", "Pamacs",
                    "Luna", "Molly", "Mázli", "Cuki", "Nokedli",
                    "Bolyhos", "Kormi", "Hópihe", "Mancs", "Garfield",
                    "Cukor", "Pötyi", "Zokni", "Tappancs", "Buksi",
                    "Picur", "Szőrmók", "Gombóc", "Cirmos", "Füles",
                    "Mokka", "Kókusz", "Pihe", "Mazsola", "Süti"
                };

            string[] cicak = new string[cicakSzama];

            for (int i = 0; i < cicakSzama; i++)
            {
                int index = r.Next(0, nevek.Length);
                cicak[i] = nevek[index];
            }

            return cicak;
        }

        private static int[,] Feltoltes(int cicakSzama)
        {
            int[,] matrix = new int[cicakSzama,3];

            for (int i = 0; i < ; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cicák száma: ");
            int cicakSzama = Convert.ToInt32(Console.ReadLine());

            cicakpontjai = Feltoltes(cicakSzama);
            string[] cicak = CicakNevei(cicakSzama);

            for (int i = 0; i < cicakpontjai.GetLength(0); i++)
            {
                Console.WriteLine($"Az {i+1,2}. cica: {cicak[i],5}\t Pontjai: ");

                for (int j = 0; j < cicakpontjai.GetLength(1); j++)
                {
                    Console.WriteLine($"{cicakpontjai[i,j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
