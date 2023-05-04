using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domacioop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kontakti k1 = new Kontakti("Marko", "Katic", "066437625");
            k1.DodajBroj("0635125425");
            k1.DodajBroj("0645354623");
            k1.DodajBroj("0661267897");
            k1.DodajBroj("0542643647");
            Console.WriteLine(k1);
            k1.IzbrisiBroj("0661267897");
            Console.WriteLine(k1);
            k1.IzbrisiBroj("0645354623");
            Console.WriteLine(k1);

            Kontakti k2 = new Kontakti("Bogdan", "lalovic", "042111112323");
            k2.DodajBroj("063858299");

            Adresar a1 = new Adresar();
            a1.Dodaj(k1);
            a1.Dodaj(k2);
            string share = @"C:fajlzaprogram.txt";
            a1.Share(share, "06472999289");

            string backup = @"C:backup.txt";
            a1.Backup(backup);

            string receive = @"C:receive.txt";
            a1.Receive(receive);
        }
    }
}
