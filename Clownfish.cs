using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    public class Clownfish : Fish, ISwims
    {
        public bool CanSwim {get; set;}
    public void Swims()
    {
        Console.WriteLine("Just keep swimming");
    }

    }
}
