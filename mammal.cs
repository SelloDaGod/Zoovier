using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    public abstract class Mammal: Animal
    {
        public int Clawsize;

        public override void Move()
        {
            Console.WriteLine("Walk");
        }

        public override void Eat()
        {
            Console.WriteLine("Mammal eats meat");
        }
    }
}
