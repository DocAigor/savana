using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savana.Model
{
    public static class FactoryAnimal
    {
        public static IAnimal AnimalBuilder(int animale) => animale switch
        {
            0 => new Gazzella(),
            1 => new Zebra(),
            2 => new Iena(),
            3 => new Leone(),
            _ => throw new Exception("Nessun animale esistente")
        };
    }
}
