using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class FlyRockPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!!");
    }
}