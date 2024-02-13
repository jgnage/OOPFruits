public class Apple : Fruit
{
    public Apple(string name) : base(name)
    {
    }

    public override void Ripen()
    {
        Console.WriteLine($"{Name} is turning red...");
    }
}