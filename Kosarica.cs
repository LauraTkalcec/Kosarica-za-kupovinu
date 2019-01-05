using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu.Logika
{
    public class Kosarica
    {
        //id
        //guid globalni id koji mozemo uzeti na internetu
        private Guid id;
        private Vlasnik vlasnik;
        private Status status;
        //stavke
        private List<Stavka> stavke; 

        //konstruktor za kosaricu
        public Kosarica(Vlasnik _vlasnik)
        {
            id = Guid.NewGuid();
            status = Status.Prazna;
            stavke= new List<Stavka>();
            vlasnik = _vlasnik;

        }

        //vrati
        public Vlasnik VratiVlasnika()
        {
            return vlasnik;
        }

        public Guid VratiId()
        {
            return id;
        }

        public Status VratiStatus()
        {
            return status;
        }

        public  List<Stavka>VratiStavke() //vracanje neceg sa puno stavaka/artikala vracamo listu tipa
        {
            return stavke;
        }

        //manipuliranje kosaricom
        
        //dodati stavku
        public void DodajStavku(Stavka s)
        {
            if (status != Status.Placena && status!= Status.Stornirana)
            {
                stavke.Add(s);
                status = Status.Aktivna;
            }else
            {
                throw new Exception();
            }
            
        }

        public void Plati()
        {
            status = Status.Placena;
        }

        public void Storniraj()
        {
            status = Status.Stornirana;
        }
        //obrisi stavku
        public void ObrisiStavku(Stavka s)
        {
            stavke.Remove(s);
        }

        //obrisi stavke
        public void Obrisi()
        {
            stavke.Clear();
        }

        //iznos kosarica
        public decimal VratiIznos()
        {
            decimal iznos = 0;
            foreach (Stavka s in stavke)
                iznos += s.VratiIznos();
            return iznos;
        }

        private  bool Zasticena()
        {
            return status == Status.Placena || status == Status.Stornirana;
        }


    }
}

//sa listom dodati, bristati sa liste, obrisati liastu
