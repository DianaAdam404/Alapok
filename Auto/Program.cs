using Auto;
Autok piros = new Autok();
piros.Marka = "Toyota";
piros.Eletkor = 5;

Autok kek = new Autok();
Console.Write("Kerem az auto markajat: ");
kek.Marka = Console.ReadLine();
Console.Write("Kerem az auto eletkorat: ");
kek.Eletkor = int.Parse(Console.ReadLine());

Console.WriteLine($"1.Peldany: {piros.Marka}, {piros.Eletkor} év.");
Console.WriteLine($"2.Peldany: {kek.Marka}, {kek.Eletkor} év.");