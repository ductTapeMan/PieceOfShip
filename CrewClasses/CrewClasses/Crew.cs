using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewClasses
{
    public abstract class Crew
    {
        protected int level;
        protected int firingSpeed;
        protected int range;
        protected string shipLocation;
        protected string nationality;
        protected int experience;
        protected string querk;
        protected string skill;

        public abstract int levelUp();
        public abstract Crew levelToClass();
    }
}
