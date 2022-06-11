using ProjetoPato.Interfaces;

namespace ProjetoPato;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.QuackSound();
    }

    public void setFlyBehavior(IFlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void setQuackBehavior(IQuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}