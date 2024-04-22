namespace CoffeeShop;

public class Whip : CoffeeShopDecorator
{
    public Whip(Beverage beverage)
    {
        this.Beverage = beverage;
    }
    public override double Cost()
    {
        return 2.22;
    }

    public override string GetDesription()
    {
        return this.Beverage.GetDescription() + " ,Milchschaum";
    }
}