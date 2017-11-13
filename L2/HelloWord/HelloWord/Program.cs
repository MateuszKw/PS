

using System;
using System.Runtime.Remoting.Lifetime;
using static System.Convert;


namespace HelloWord
{
    internal class Program
    {
        private static byte[] tablica = new byte[9] {0, 1, 2, 3, 4, 5, 6, 7, 8};
        public static void Main(string[] args)
        {
            Console.WriteLine(Program.bitCRC(tablica));
            
        }

        public static int getBite(byte B, int Number)
        {
            return ToInt32((B & (1 << Number - 1)) != 0);
        }

        public static int bitCRC(byte[]tablica)
        {
            var Ile = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (getBite(tablica[i], j) == 1)
                    {
                        Ile++;
                    }
                }
            }
            if ((Ile % 2) == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    
}