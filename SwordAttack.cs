using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mis321_pa2_Jack_Green2031.Interfaces;

namespace mis321_pa2_Jack_Green2031
{
    public class SwordAttack : IAttack
    {
        public string Attack()
        {
            return "You attacked with a sword!";
        }
    }
}