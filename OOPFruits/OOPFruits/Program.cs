namespace FruitShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> shoppingCart = new List<Fruit>();

            while (true)
            {
                Console.WriteLine("Welcome to the Fruit Shopping Cart!");
                Console.WriteLine("1. Add Apple");
                Console.WriteLine("2. Add Banana");
                Console.WriteLine("3. Add Orange");
                Console.WriteLine("4. Add Grape");
                Console.WriteLine("5. View Shopping Cart");
                Console.WriteLine("6. Check the fruit to see if it's ripe!");
                Console.WriteLine("7. Checkout");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        shoppingCart.Add(new Apple("Apple"));
                        Console.WriteLine("Apple added to the shopping cart!");
                        break;
                    case "2":
                        shoppingCart.Add(new Banana("Banana"));
                        Console.WriteLine("Banana added to the shopping cart!");
                        break;
                    case "3":
                        shoppingCart.Add(new Orange("Orange"));
                        Console.WriteLine("Orange added to the shopping cart!");
                        break;
                    case "4":
                        shoppingCart.Add(new Grape("Grape"));
                        Console.WriteLine("Grape added to the shopping cart!");
                        break;
                    case "5":
                        Console.WriteLine("Items in the shopping cart:");
                        foreach (var fruit in shoppingCart)
                        {
                            Console.WriteLine(fruit.Name);
                        }
                        break;
                    case "6":
                        Console.Write("Enter the name of the fruit you want to check: ");
                        string fruitNameToCheck = Console.ReadLine();
                        Fruit fruitToCheck = shoppingCart.Find(fruit => fruit.Name.Equals(fruitNameToCheck, StringComparison.OrdinalIgnoreCase));
                        if (fruitToCheck != null)
                        {
                            Console.WriteLine($"Checking if {fruitToCheck.Name} is ripe...");
                            if (fruitToCheck.CheckRipeness())
                            {
                                Console.WriteLine($"{fruitToCheck.Name} is ripe!");
                            }
                            else
                            {
                                Console.WriteLine($"{fruitToCheck.Name} is not ripe yet.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No fruit named '{fruitNameToCheck}' found in the shopping cart.");
                        }
                        break;
                    case "7":
                        double totalPrice = CalcPrice(shoppingCart);
                        Console.WriteLine($"Total price of the shopping cart: ${totalPrice}");
                        break;
                    case "8":
                        Console.WriteLine("Thank you for shopping here!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
        static double CalcPrice(List<Fruit> fruits)
        {
            double totalPrice = 0;
            foreach (var fruit in fruits)
            {
                totalPrice += 1;
            }
            return totalPrice;
        }
    }
}
