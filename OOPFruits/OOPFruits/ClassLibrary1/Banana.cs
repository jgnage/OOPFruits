public class Banana : Fruit
{
    public Banana(string name) : base(name)
    {
    }

    public override void Ripen()
    {
        Console.WriteLine($"{Name} is getting yellow spots...");
    }
}