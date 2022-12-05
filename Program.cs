using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jaja
{
    internal class Program
    {
        class Elementy
        {
            int[] tab = { 1, 3, 4, 6, 8, 0 };
            public void elementy()
            {
                int w = 0;
                int l = tab.Length;
                for(int i = 0; i < l / 2; i++)
                {
                    w = tab[i];
                    tab[i] = tab[l-i-1];
                    tab[l-i-1] = w;

                }
            }
            public int Wypisywanie()
            {
                foreach(int i in tab)
                {
                    Console.WriteLine("i tak to nie działa: " + i);
                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Elementy element = new Elementy();
            element.elementy();
            element.Wypisywanie();
        }
    }
}
