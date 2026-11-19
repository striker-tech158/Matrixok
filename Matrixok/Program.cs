namespace Matrixok
{
    internal class Program
    {
        static Random r = new Random();
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;

        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];

        static void F01()
        {
            for (int i = 0; i < sorokSzama; i++)//sorokon megy végig
            {
                for (int j = 0; j < oszlopokSzama; j++)//oszlopokon megy végig
                {
                    szamokMatrix[i, j] = r.Next(10, 100);//10-99 közötti számokkal töltöm fel a mátrixot
                }
            }
        }

        static void F02()
        {
           for (int i = 0; i < sorokSzama; i++)
           {
              for (int j =0; j < oszlopokSzama; j++)
              {
                 Console.Write(szamokMatrix[i, j] + " ");
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
        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
        }
    }
}
