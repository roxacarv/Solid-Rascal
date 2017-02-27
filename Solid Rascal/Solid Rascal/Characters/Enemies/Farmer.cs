﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rascal.Characters.Enemies
{
    class Farmer : Character
    {
        public Farmer()
        {
            sDEF = 0;

            cName = "Farmer";
            cType = 105;

            sHP = 10;
            sMHP = 10;
        }

        public override int GetAttackRoll()
        {
            return _die.Roll(1, 6);
        }
    }
}
