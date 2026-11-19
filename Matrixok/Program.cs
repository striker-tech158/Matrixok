namespace Matrixok
{
    internal class Program
    {
        static Random r = new Random();
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;

        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static int[,] negyzetesmatrix = new int[sorokSzama, oszlopokSzama];

        static void F01(int[,]matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)//sorokon megy végig
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//oszlopokon megy végig
                {
                    matrix[i, j] = r.Next(min, max+1);//10-99 közötti számokkal töltöm fel a mátrixot
                }
            }
        }

        static void F02(int[,] matrix)
        {
           for (int i = 0; i < matrix.GetLength(0); i++)
           {
              for (int j =0; j < matrix.GetLength(1); j++)
              {
                 Console.Write($"{matrix[i, j], 5}");//5 karakternyi helyet hagy az értékeknek kiírásnál
              }
              Console.WriteLine();
           }
            Console.WriteLine();
        }

        static void F03()
        {
            int osszeg = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    osszeg += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A mátrixban lévő elemek összege: {osszeg}");
        }

        static void F04()
        {
            Console.WriteLine();
            for (int i = 0; i < sorokSzama; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    osszeg += szamokMatrix[i, j];
                }
                Console.WriteLine($"{i+1}. sor összege {osszeg}");
            }
        }

        static void F05()
        {
            Console.WriteLine();
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int osszeg = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    osszeg += szamokMatrix[i, j];
                }
                Console.WriteLine($"{j + 1}. oszlop összege {osszeg}");
            }
        }
        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            F04();
            F05();
            Console.WriteLine("---------------------------------------------------");
            F01(negyzetesmatrix, -100, 100);
            F02(negyzetesmatrix);
        }
    }
}
