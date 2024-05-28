using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface IDoktor
    {
        public void dodajPacijenta(Pacijent pacijent);
        public void ukloniPacijena(Pacijent pacijent);

        void Obavesti();

    }
}
