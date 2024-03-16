using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2turnip
{
    internal class Character
    {
        public string Name { get; private set; }

        public Character(string name)
        { 
            this.Name = name; 
        }

        public bool Pull(IHerb herb)
        {
            return herb.TryToPull();
        }
    }
}
