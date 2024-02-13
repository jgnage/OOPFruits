public class Orange : Fruit
{
    public Orange(string name) : base(name)
    {
    }

    public override void Ripen()
    {
        Console.WriteLine($"{Name} is getting orange...");
    }
}
