using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Doktor : IDoktor
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }


        private List<Pacijent> pacijenti { get; set; } = new List<Pacijent>();

        public void dodajPacijenta(Pacijent pacijent)
        {
            this.pacijenti.Add(pacijent);
            Console.WriteLine($"Dr.{this.Ime} {this.Prezime} je preuzeo pacijenta:{pacijent.Ime} {pacijent.Prezime}" + Environment.NewLine);

        }

        public void Obavesti()
        {
            foreach (Pacijent p in this.pacijenti)
            {
                p.Obavesti();
            }
        }
        public void Odmor()
        {
            Console.WriteLine("Doktor je otisao na odmor" + Environment.NewLine);
            this.Obavesti();
        }

        public void ukloniPacijena(Pacijent pacijent)
        {
            Pacijent? p = this.pacijenti.Where(x=> x.Ime ==  pacijent.Ime).FirstOrDefault();
            if (p != null)
            {

            this.pacijenti.Remove(p);
            Console.WriteLine($"Dr.{this.Ime} {this.Prezime} nije vise zaduzen za pacijenta:{pacijent.Ime} {pacijent.Prezime}" + Environment.NewLine);
            }

        }
    }
}
