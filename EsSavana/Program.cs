using System;
using Model;
using Creation;
using System.Collections.Generic;
using Savana.Logic;

namespace EsSavana
{
    class Program
    {
        static void Main(string[] args)
        {
            var  lista= new List<IAnimal>();
            Console.WriteLine("Popola la Savana!");
            Console.WriteLine("Quante zebre ci sono?");
            int nZebre = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < nZebre; i++)
            {
                var _zebra= AnimalCreator.Creation("Zebra");
                lista.Add(_zebra);
            }
            Console.WriteLine("Quante gazzelle ci sono?");
            int nGazze = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nGazze; i++)
            {
                var _Gazze = AnimalCreator.Creation("Gazzella");
                lista.Add(_Gazze);
            }
            Console.WriteLine("Quanti leoni ci sono?");
            int nLeoni = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nLeoni; i++)
            {
                var _leone = AnimalCreator.Creation("Leone");
                lista.Add(_leone);
            }
            Console.WriteLine("Quante iene ci sono?");
            int nIene = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nIene; i++)
            {
                var _iene = AnimalCreator.Creation("Iena");
                lista.Add(_iene);
            }


        }

        public string CircleLife(List<IAnimal> listaAnimal)
        {
            do
            {
                LogicaSavana.WakeUp(listaAnimal);
                return LogicaSavana.Check(listaAnimal);

            } while (LogicaSavana.Check(listaAnimal));

        }
    }
}
