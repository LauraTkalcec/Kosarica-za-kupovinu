using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu.Logika
{
    public class Stavka
    {
        private string opis; // sto sam kupio
        private int kolicina;
        private decimal cijena;

        // 2 konstruktora
        public Stavka(string _opis, decimal _cijena)
        {
            opis = _opis;
            cijena = _cijena;
            kolicina = 1;
        }

        public Stavka(string _opis, decimal _cijena, int _kolicina)
        {
            opis = _opis;
            cijena = _cijena;
            kolicina = _kolicina;
        }

        public decimal VratiIznos()
        {
            return cijena * kolicina;
        }
        //ToString
        public override string ToString()
        {
            return String.Format("{0,-30}{1,5}{2,10:F2}{3,10:F2}", opis, kolicina, cijena, VratiIznos());
 
        }
    }
}
