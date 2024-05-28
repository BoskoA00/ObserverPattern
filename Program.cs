


using ObserverPattern;

Doktor doktor = new Doktor() { Ime="Darko",Prezime="Markovic" };
Pacijent pacijent1 = new Pacijent() { Ime = "Stefan", Prezime = "Stefanovic", Kontakt ="722-222"};
Pacijent pacijent2 = new Pacijent() { Ime = "Marko", Prezime = "Markovic", Kontakt = "733-222" };
Pacijent pacijent3 = new Pacijent() { Ime = "Janko", Prezime = "Jankovic", Kontakt = "744-222" };

doktor.dodajPacijenta(pacijent1);
doktor.dodajPacijenta(pacijent2);
doktor.dodajPacijenta(pacijent3);

doktor.Odmor();

doktor.ukloniPacijena(pacijent1);

doktor.Odmor(); 



Console.ReadLine();