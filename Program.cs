using KosaricaZaKupovinu.Logika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //ude Marko u dućan
            Vlasnik marko = new Vlasnik("markom@mev.com",  "Marko Markovic",  "Mihovljanska 12, Čakovec");
            Console.WriteLine("Kupac: {0}", marko);

            //Marko mijenja adresu
            Console.WriteLine("Kupac mijenja adresu: ");
            marko.PromijeniAdresu("A.G.Matoša 113, Varaždin");
            Console.WriteLine("Kupac: {0}", marko);

            //Marko uzima kosaricu  --Console.WriteLine("Kupac uzima kosaricu: ");
            Kosarica markovaKosarica = new Kosarica(marko); //pise marko je uzeo kosaricu



            //Marko kupuje
             Stavka st=new Stavka("TV LG 58 615", 8667.23m);
           // markovaKosarica.DodajStavku(new Stavka("TV LG 58 615", 8667.23m)); //dodati m za decimal
            markovaKosarica.DodajStavku(new Stavka("produzni kabel", (54.45m), 2));
            markovaKosarica.DodajStavku(new Stavka("antena", (123.50m), 1));

            markovaKosarica.ObrisiStavku(st);

            //ispisati kosaricu
            Console.WriteLine("\nIspis kosarice: \nid:{0}\nKupac:{1}\nStatus:{2}\nStavke:", markovaKosarica.VratiId(), markovaKosarica.VratiVlasnika(), markovaKosarica.VratiStatus());

            //ispis stavaka
            int brojac = 0;
            foreach(Stavka s in markovaKosarica.VratiStavke() )
            {
                Console.WriteLine("{0}.{1}", ++brojac, s);
            }

            //ukupno
            Console.WriteLine();
            Console.WriteLine("ukupno za platiti: {0}  kn.", markovaKosarica.VratiIznos());


        }
    }
}
