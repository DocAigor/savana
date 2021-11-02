namespace Savana.Model
{
    public class Carnivoro : IAnimal
    {
        public int Digiuno; 
        public bool Eat(ICibo cibo) => cibo.GetType() == typeof(Erbivoro);

    }

}
