using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class Squeak : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("Squeak");
    }
}