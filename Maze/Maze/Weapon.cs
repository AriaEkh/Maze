using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Weapon: Entity
    {
        private int damage;

        public Weapon()
        {
            Random rnd = new Random();
            damage = rnd.Next(1, 11);
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
    }
}
