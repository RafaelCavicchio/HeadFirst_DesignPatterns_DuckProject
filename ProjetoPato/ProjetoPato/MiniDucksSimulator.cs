using ProjetoPato.Concrete;

namespace ProjetoPato;

public class MiniDucksSimulator
{
    public static void InitialMethod(string[] args)
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.PerformQuack();
        mallardDuck.PerformFly();

        Duck model = new ModelDuck();
        model.PerformFly();
        model.setFlyBehavior(new FlyRockPowered());
        model.PerformFly();
    }
}