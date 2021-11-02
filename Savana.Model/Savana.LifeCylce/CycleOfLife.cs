
using Savana.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Savana.LifeCylce
{

    public static class CycleOfLife
    {
        public static List<(IAnimal Animali, int Digiuno)> God()
        {
            List<(IAnimal,int)> savana = new();
            for (var ii = 0; ii < 10; ii++)
            {
                var animale = new Random();
                animale.Next(0, 3);
                savana.Add((FactoryAnimal.AnimalBuilder(Convert.ToInt32(animale)),0));
            }
            return savana;
        }
        public static bool CheckTypeOfAnimal(List<(IAnimal,int)> savana)
        {
            int numbHerb = 0;
            int numbCarn = 0;
            foreach (var tmp in savana)
            {
                if (tmp.Item1.GetType().IsSubclassOf(typeof(Herbivor)))
                    numbHerb++;
                else
                    numbCarn++;
            }
            if (numbCarn == 0 || numbHerb == 0)
                return false;
            return true;
        }
        public static List<(IAnimal, int)> WakeUp(List<(IAnimal,int)> savana)
        {
            int randFirst;
            int randSecond;
            do
            {
                randFirst = Convert.ToInt32(new Random().Next(0, savana.Count() - 1));
                randSecond = Convert.ToInt32(new Random().Next(0, savana.Count() - 1));
            } while (randFirst == randSecond);

            var firstAnimal = savana[randFirst];
            var secondAnimal = savana[randSecond];

            if (secondAnimal.Item1.GetTipo() == firstAnimal.Item1.GetTipo())
                return savana;

            if (firstAnimal.Item1.GetTipo() == "Carnivore")
                savana.RemoveAt(randSecond);
            else
                savana.RemoveAt(randFirst);

            return savana;
        }
    }





}
