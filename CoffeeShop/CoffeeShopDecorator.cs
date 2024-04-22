namespace CoffeeShop;

public abstract class CoffeeShopDecorator : Beverage
{
    public Beverage Beverage;

    public abstract String GetDesription();
}