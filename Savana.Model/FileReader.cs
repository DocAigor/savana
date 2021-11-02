using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Savana.Model
{
    public class FileReader
    {
        public IList<string> Read(string path) => File.ReadAllLines(path);
    }
}
