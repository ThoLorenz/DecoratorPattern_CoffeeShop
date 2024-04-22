namespace CoffeeShop;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "HouseBlend";
    }
    public override double Cost()
    {
        return 3.09;
    }
}