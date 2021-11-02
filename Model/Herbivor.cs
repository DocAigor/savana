using System;

namespace Model
{
    public class Herbivor : IAnimal, ICibo
    {
        public string Specie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Eat(ICibo cibo) => cibo.GetType() == typeof(Erba);
        
    }
}
