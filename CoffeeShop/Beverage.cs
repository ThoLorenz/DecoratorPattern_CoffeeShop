namespace CoffeeShop;

public abstract class Beverage
{
    public string Description = "unbekanntes Getränk";

  
    public string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}