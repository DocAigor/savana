
namespace Savana.Model
{
    public interface IAnimal : ICibo
    {
        public bool Eat(ICibo cibo);

        public string GetTipo();
    }
}
