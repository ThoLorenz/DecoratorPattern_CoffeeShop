namespace CoffeeShop;

public class Mocca : CoffeeShopDecorator
{
    

    public Mocca(Beverage beverage)
    {
        this.Beverage = beverage;
    }

    public override double Cost()
    {
        return this.Beverage.Cost() + .20;
    }

    public override string GetDesription()
    {
        return this.Beverage.GetDescription() + " ,Mocca";
    }
}