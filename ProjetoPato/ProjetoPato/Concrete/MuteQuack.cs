using ProjetoPato.Interfaces;

namespace ProjetoPato.Concrete;

public class MuteQuack : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("<< Silence >>");
    }
}