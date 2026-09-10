using Bankszamla;
Console.WriteLine("Befizetes: [1]   Kifizetes:  [2]");
string irany=Console.ReadLine();

Bankszam peldany=new Bankszam();

if (irany == "1")
{
    //befizetes
    Console.WriteLine("Kerem a befizetes osszeget: ");
    double be=Convert.ToDouble(Console.ReadLine());
    peldany.Befizetes(be);

}
else
{
    //kifizetes
    Console.WriteLine("Kerem a kifizetni kivant osszeget: ");
    double ki=Convert.ToDouble(Console.ReadLine());
    peldany.Kivet(ki);
}
