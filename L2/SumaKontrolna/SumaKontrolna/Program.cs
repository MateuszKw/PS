

using System;
namespace SumaKontrolna
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            byte b, a;
            byte m;
            char[] cos2 = new char[] {'d', 'g', 't', 'r'};
            a = 0;
            foreach (var v in cos2)
            {
                for (int j = 0; j < 8; j++)
                {
                    m = (byte) (1 << (j - 1));
                    b = (byte) ((v & m) >> (j - 1));
                    a ^= b;
                }
            }
            Console.WriteLine(a);
        }
    }
    
}