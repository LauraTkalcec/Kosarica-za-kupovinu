using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu.Logika
{
   public class Vlasnik
    {
        private string id;
        private string naziv;
        private string adresa;

        //konstruktor
        public Vlasnik(string _id,string _naziv, string _adresa)
        {
            id = _id;
            naziv = _naziv;
            adresa = _adresa;
        }

        //vrati metode

        //ToString-ispisuje podatke o kupcu
        public override string ToString()
        {
            return String.Format("{0}/{1}, {2}", id, naziv, adresa);
        }

        //promjeni adresu
        public void PromijeniAdresu(string novaAdresa)
        {
            adresa = novaAdresa;
        }


    }
}
