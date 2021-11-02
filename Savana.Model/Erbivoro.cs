namespace Savana.Model
{
    public class Erbivoro : IAnimal, ICibo
    {
        public bool Eat(ICibo cibo) => false;
    }

}
