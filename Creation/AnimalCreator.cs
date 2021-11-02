using Model;
using System;

namespace Creation
{
    public class AnimalCreator
    {
        public static IAnimal Creation(string specie) => specie switch
        {
            "Zebra" => new Zebra(),
            "Gazzella" => new Gazzella(),
            "Leone" => new Leone(),
            "Iena" => new Iena(),
            _ => throw new Exception("Animale inesistente")
        };
        
    }
}
