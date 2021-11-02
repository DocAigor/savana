using System;

namespace Savana.cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Test()
        {

            var animaliSavana = Savana.LifeCylce.CycleOfLife.God();

            if (!Savana.LifeCylce.CycleOfLife.CheckTypeOfAnimal(animaliSavana))
            {
                Console.WriteLine("Si è rotto l'equilibrio naturale");
            } else
            {
                var savana= Savana.LifeCylce.CycleOfLife.WakeUp(animaliSavana);




                //Crea un oggetto savana to sql al quale passi un oggetto savana to file in modo che chiamato il primo, parta anche il secondo.
            }




        }
    }
}
