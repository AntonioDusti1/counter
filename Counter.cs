using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PravaKlasa
{ 
class PravaKlasa
{
    private static int counter = 0;
        private string naziv;
    public PravaKlasa(string naziv)
    {
        counter++;
            this.naziv = naziv;
    }
    public static int GetCounter() { return counter; }
public string GetNaziv() { return naziv; }
}
internal class Program
{
    static void Main(string[] args)
    {
        PravaKlasa x = new PravaKlasa("Prvi");
        PravaKlasa y = new PravaKlasa("Drugi");
        PravaKlasa z = new PravaKlasa("Treći");
            Console.WriteLine(x.GetNaziv());
            Console.WriteLine(y.GetNaziv());
            Console.WriteLine(z.GetNaziv());
            Console.WriteLine("Vrijednost: " + PravaKlasa.GetCounter());
            Console.WriteLine("Vrijednost: " + PravaKlasa.GetCounter());
            Console.WriteLine("Vrijednost: " + PravaKlasa.GetCounter());
            Console.ReadKey();
        }
}
}
