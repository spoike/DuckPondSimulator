namespace DuckPond.ConsoleApp
{
    public class RubberDuckie : Duck
    {
        public RubberDuckie()
        {
            Name = "Rubber Duckie";
            QuackBehavior = new Squeak();
            FlyBehavior = new NoFly();
        }
    }
}