using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2turnip
{
    internal class Turnip : IHerb
    {
        private int weight;

        public void Grow()
        {
            weight = new Random().Next(1, 5);
        }

        public bool TryToPull()
        {
            weight--;
            return weight <= 0;
        }
    }
}
