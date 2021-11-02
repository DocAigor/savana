using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IAnimal
    {
        string Specie { get; set; }
        bool Eat(ICibo cibo);
    }
}
