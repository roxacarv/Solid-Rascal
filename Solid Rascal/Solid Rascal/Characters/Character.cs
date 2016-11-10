﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Rascal.Characters
{
    class Character
    {
        public string charNAME;

        Random rand;

        public int xPos { get; set; }
        public int yPos { get; set; }
        public int charID { get; set; }

        public int sLEVEL { get; set; }
        public int sARMOR { get; set; }
        public int sSTR { get; set; }
        public int sMSTR { get; set; }
        public int sHP { get; set; }
        public int sMHP { get; set; }

        public int _AiState { get; }
        public int _AiChoice;

        public Character()
        {
            _AiState = 1;
            _AiChoice = 0;
            rand = MainGame.rand;
        }

        public void SetNewPosition(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void IncreaseHealth(int value)
        {
            sHP += value;

            if (sHP > 100)
            {
                sHP = 100;
            }
        }

        public void ReduceHealth(int value)
        {
            sHP -= value;
            if (sHP < 0)
            {
                sHP = 0;
            }
        }

        public int AiMovement()
        {
            switch (_AiState)
            {
                case 1:
                    //Idle
                    return rand.Next(1, 5);
                case 2:
                    //Chase
                    return 0;
                case 3:
                    //Attack;
                    return 0;
                default:
                    return 0;
                    break;
            }
        }
    }
}
