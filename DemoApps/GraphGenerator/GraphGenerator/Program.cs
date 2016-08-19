using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphGen gg = new GraphGen(1 << 20, 16, 100);
            gg.CreatGraph();
        }
    }
}
