﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rascal.Characters.Enemies
{
    class Zombie : Character
    {
        public Zombie()
        {
            sDEF = 0;

            cName = "Zombie";
            cType = 125;

            sHP = 10;
            sMHP = 10;
        }

        public override int GetAttackRoll()
        {
            return _die.Roll(1, 6);
        }
    }
}
