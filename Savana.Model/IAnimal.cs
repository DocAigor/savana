using System;

namespace Savana.Model
{
    public interface IAnimal
    { 
        string Alimentazione { get; set; }
        string Nome { get; set; }
        bool Eat(ICibo cibo);
    }


}
