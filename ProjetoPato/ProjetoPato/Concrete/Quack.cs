using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class Quack : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("Quack");
    }
}