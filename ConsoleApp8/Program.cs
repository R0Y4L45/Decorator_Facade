public interface MobileShop
{
    public void modelNo();
    public void price();
}

public class Iphone : MobileShop
{
    public void modelNo()
    {
        Console.WriteLine(" Iphone 6 ");
    }
    public void price()
    {
        Console.WriteLine(" Rs 65000.00 ");
    }
}


public class Samsung : MobileShop
{
    public void modelNo()
    {
        Console.WriteLine(" Samsung galaxy tab 3 ");
    }
    public void price()
    {
        Console.WriteLine(" Rs 45000.00 ");
    }
}

public class Blackberry : MobileShop
{
    public void modelNo()
    {
        Console.WriteLine(" Blackberry Z10 ");
    }
    public void price()
    {
        Console.WriteLine(" Rs 55000.00 ");
    }
}


public class ShopKeeper
{
    private MobileShop iphone;
    private MobileShop samsung;
    private MobileShop blackberry;

    public ShopKeeper()
    {
        iphone= new Iphone();
        samsung=new Samsung();
        blackberry=new Blackberry();
    }
    public void iphoneSale()
    {
        iphone.modelNo();
        iphone.price();
    }
    public void samsungSale()
    {
        samsung.modelNo();
        samsung.price();
    }
    public void blackberrySale()
    {
        blackberry.modelNo();
        blackberry.price();
    }
}


public class FacadePatternClient
{
    private static int choice;
    public static void Main()
    {
        do
        {
            Console.WriteLine("========= Mobile Shop ============ \n");
            Console.WriteLine("            1. IPHONE.              \n");
            Console.WriteLine("            2. SAMSUNG.              \n");
            Console.WriteLine("            3. BLACKBERRY.            \n");
            Console.WriteLine("            4. Exit.                     \n");
            Console.WriteLine("Enter your choice: ");

            choice = int.Parse(Console.ReadLine()!);
            
            ShopKeeper sk = new ShopKeeper();

            switch (choice)
            {
                case 1:
                    {
                        sk.iphoneSale();
                    }
                    break;
                case 2:
                    {
                        sk.samsungSale();
                    }
                    break;
                case 3:
                    {
                        sk.blackberrySale();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nothing You purchased");
                    }
                    return;
            }

        } while (choice!=4);
    }
}