using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    public abstract class Bird: Animal
    {
        public int wingSpan;
        public int beakSize;

        public override void Move()
        {
            Console.WriteLine("Fly");
        }
        public override void Eat()
        {
            Console.WriteLine("bird eats worm");
        }
    }
}
