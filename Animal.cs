using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoovier
{
    public abstract class Animal
    {
        public string name;
        public int size;
        
        public abstract void Move();

        public abstract void Eat();

        public abstract void Drink();
       
    }
}
