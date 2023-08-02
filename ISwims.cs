using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    internal interface ISwims
    {
        public bool CanSwim { get; set; }
        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }
    }
}
