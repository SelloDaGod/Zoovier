using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    internal class Bear: Mammal, IWalks
    {
     public string FurColor;
        public int legs { get; set; }
        public override void Drink()
        {
            Console.WriteLine("Bear drinks");
        }
    }
}
