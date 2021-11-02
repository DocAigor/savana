namespace Savana.Model
{
    public class Herbivor : IAnimal
    {
        public bool Eat(ICibo cibo) => cibo.GetType() == typeof(Grass) ? true : false;

        public string GetTipo() => "Herbivore";
 
    }
}