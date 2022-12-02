namespace Decarator;
public interface Vehicle
{
    string Make { get; }
    string Model { get; }
    double Price { get; }
}

/// ConcreteComponent
public class X5 : Vehicle
{
    public string Make
    {
        get { return "X5"; }
    }

    public string Model
    {
        get { return "CNG"; }
    }

    public double Price
    {
        get { return 1000000; }
    }
}

/// Decorator
public abstract class VehicleDecorator : Vehicle
{
    private Vehicle _vehicle;

    public VehicleDecorator(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public string Make
    {
        get { return _vehicle.Make; }
    }

    public string Model
    {
        get { return _vehicle.Model; }
    }

    public double Price
    {
        get { return _vehicle.Price; }
    }

}


//The ConcreteDecorator

public class SpecialOffer : VehicleDecorator
{
    public int DiscountPercentage { get; set; }
    public string? Offer { get; set; }

    public double Price
    {
        get
        {
            double price = base.Price;
            int percentage = 100 - DiscountPercentage;
            return Math.Round((price * percentage) / 100, 2);
        }
    }

    public SpecialOffer(Vehicle vehicle) : base(vehicle) { }
}


class Program
{
    static void Main()
    {
        X5 car = new X5();

        Console.WriteLine($"Price : {car.Price}");

        SpecialOffer offer = new SpecialOffer(car);
        offer.DiscountPercentage = 25;
        offer.Offer = "25 % discount";

        Console.WriteLine($"{offer.Offer}  Special Offer and price are : {offer.Price} ");

    }
}