using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Case
    {
        private Entity entity;
        private CaseType type;

        public enum CaseType
        { empty, wall, exit };

        public Case(CaseType type)
        {
            entity = null;
            this.type = type;
        }

        public Entity Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public CaseType Type
        {
            get { return type; }
        }
    }
}
