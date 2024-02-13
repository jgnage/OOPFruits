public class Fruit
{
    public string Name { get; set; }
    public bool IsRipe { get; private set; }

    public Fruit(string name)
    {
        Name = name;
        IsRipe = false; 
    }

    public virtual void Ripen()
    {
        Console.WriteLine($"{Name} is ripening...");
        IsRipe = true; 
    }

    public bool CheckRipeness()
    {
        return IsRipe; // Return the value of IsRipe
    }
}
