using Savana.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prova
{
    public class Program
    {
        private static string path;

        static void Main(string[] args)
        {
            var reader = new FileReader();
            var listaAnimali = reader.Read(path).Select(x => SavanaFactory.Build(x)).ToList();
            var savana = new Savana.Model.Savana(listaAnimali);


        }
    }
}
