using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savana.Model
{
    public class Savana
    {
        private IList<IAnimal> _listaAnimali;
        public Savana(IList<IAnimal> listaanimali)
        {
            _listaAnimali = listaanimali;
        }
        public void WakeUp()
        {
            var random = new Random();
            var animale = _listaAnimali.ElementAt(random.Next(0, _listaAnimali.Count() - 1));
            var animale1 = _listaAnimali.ElementAt(random.Next(0, _listaAnimali.Count() - 1));
           



            if (animale.GetType().IsSubclassOf(typeof(Erbivoro)) != animale1.GetType().IsSubclassOf(typeof(Carnivoro)) 
                || animale.GetType().IsSubclassOf(typeof(Carnivoro)) != animale1.GetType().IsSubclassOf(typeof(Erbivoro)))
            {
                if (verifica)
                {
                    animale.Eat(animale1);
                }

            }
        }

        

            public bool check() => _listaAnimali.Where(x => x.GetType().IsSubclassOf(typeof(Erbivoro))).Any();

    }
}
