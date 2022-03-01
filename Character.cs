using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mis321_pa2_Jack_Green2031.Interfaces;

namespace mis321_pa2_Jack_Green2031
{
    public class Character
    {
        public string name {get; set;}
        public int charType {get; set;}
        public double maxPower {get; set;}
        public double health {get; set;}
        public double aPower {get; set;}
        public double dPower {get; set;}
        public bool isTaken {get; set;}
        public IAttack attackBehavior {get; set;}

        public Character()
        {
            attackBehavior = new DistractAttack();
        }

        public override string ToString()
        {
            return $"{this.name} -- max power of {this.maxPower}, health of {this.health}, attack power of {this.aPower}, and defence power of {this.dPower}";
        }
    }
}