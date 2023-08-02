using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoovier;

namespace Zoovier
{
    internal class Stork : Bird
    {
        public Stork(string featherColor)
        {
            color = featherColor;
        }

        public string color;

        public override void Drink()
        {
            // Implement the drinking behavior for the Stork
            Console.WriteLine("The stork drinks water.");
        }
    }
}






