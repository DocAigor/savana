namespace Model
{
    public class Carnivor : IAnimal
    {
        public string Specie { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public bool Eat(ICibo cibo) => cibo.GetType() == typeof(Herbivor);
        
        
    }
}
