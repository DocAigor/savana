using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Savana.Logic
{
    public class LogicaSavana
    {
        public LogicaSavana()
        {

        }
        public static bool Check(List<IAnimal> lista)
        {
            int numErb = lista.Where(x => x.GetType().IsSubclassOf(typeof(Herbivor))).Count();
            int numCar = lista.Where(x => x.GetType().IsSubclassOf(typeof(Carnivor))).Count();
            return numErb> 0 && numCar>0 ;
        }

        public static List<IAnimal> WakeUp(List<IAnimal> lista)
        {
            Random r = new Random();
            int r1 = r.Next(0, lista.Count-1);
            int r2 = r.Next(0, lista.Count - 1);
            var firstanimal = lista.ElementAt(r1);
            var secondanimal = lista.ElementAt(r2);

            if (firstanimal.GetType().IsSubclassOf(typeof(Herbivor)) && secondanimal.GetType().IsSubclassOf(typeof(Carnivor)))
                lista.RemoveAt(r1);
            else if (firstanimal.GetType().IsSubclassOf(typeof(Carnivor)) && secondanimal.GetType().IsSubclassOf(typeof(Herbivor)))
                lista.RemoveAt(r2);
            return lista;
        }
    }
}
