using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying!!");
    }
}