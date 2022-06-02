Hero cardUno = new Hero("Elemental Hero Sparkman", 4);
Console.WriteLine("{0}, Level {1}", cardUno.Name, cardUno.Level);
Hero cardDos = new Hero("Elemental Hero Clayman", 4);
Console.WriteLine("{0}, Level {1}", cardDos.Name, cardDos.Level);
Hero cardFuse = new Hero("Elemental Hero Thunder Giant", 6);
Console.WriteLine("I use Polymerization on {0} and {1} to fusion summon: {2}, Level {3}", cardUno.Name, cardDos.Name, cardFuse.Name, cardFuse.Level);
public class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public Hero(string name, int level)
    {
        Name = name;
        Level = level;
    }
}


