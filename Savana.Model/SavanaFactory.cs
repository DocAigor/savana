using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savana.Model
{
    public static class SavanaFactory
    {
        public static IAnimal Build(string nome) => nome switch
        {
            "Zebra" => new Zebra(),
            "Elefante" => new Elefante(),
            "Iena" => new Iena(),
            "Leone" => new Leone(),
            _ => throw new Exception()
        };
    }
}
