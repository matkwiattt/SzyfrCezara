using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            char przed_szyfrowaniem;
            char po_szyfrowaniu;
            Console.WriteLine("Podaj przesunięcie: ");
            int przesuniecie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź szyfr:");
            do
            {
                przed_szyfrowaniem = Convert.ToChar(Console.ReadKey(true).KeyChar);
                if (przed_szyfrowaniem >= 'a' && przed_szyfrowaniem <= 'z')
                {
                    
                    int x = przed_szyfrowaniem + przesuniecie;
                    if (x > 'z')
                    {
                        x = x - ('z' - 'a' + 1);
                    }
                    else if (x < 'a')
                    {
                        x = x + ('z' - 'a' + 1);
                    }
                    po_szyfrowaniu = Convert.ToChar(x);
                    Console.Write(po_szyfrowaniu);
                }
                else
                {
                    Console.Write(przed_szyfrowaniem);
                }
            }
                while (przed_szyfrowaniem != 'q');
        }
    }
}