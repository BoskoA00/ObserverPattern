using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Pacijent : IPacijent
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }



        public void Obavesti()
        {
            Console.Write($"Obavesten pacijent {this.Ime} {this.Prezime} na broj:{this.Kontakt}" + Environment.NewLine);
        }
    }
}
