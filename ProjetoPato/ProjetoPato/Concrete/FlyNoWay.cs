using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't Fly");
    }
}