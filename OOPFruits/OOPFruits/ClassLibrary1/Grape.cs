public class Grape : Fruit
{
    public Grape(string name) : base(name)
    {
    }

    public override void Ripen()
    {
        Console.WriteLine($"{Name} is getting sweeter...");
    }
}