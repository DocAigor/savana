namespace Savana.Model
{
    public class Carnivor : IAnimal
    {
        public bool Eat(ICibo cibo) => cibo.GetType() == typeof(Herbivor) ? true : false;
        public string GetTipo() => "Carnivore";

    }
}