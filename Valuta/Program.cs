using Valuta;
//peldany parositott
ValutaValto januar = new ValutaValto();
januar.Arfolyam = 370;
Console.WriteLine($"Euro: 100, Árfolyam:{januar.EurorolHuf(100)} Ft");

ValutaValto februar = new ValutaValto();
februar.Arfolyam = 380;
Console.WriteLine($"Euro: 100, Árfolyam:{februar.EurorolHuf(100)} Ft");

//nem peldany parositott            static
Console.WriteLine($"Euro: 100, Árfolyam:{ValutaValto.FixEurorolHuf(100)} Ft");
