using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Battle
{

    /**
     * 
     */

    [System.Serializable]
    public class BaseMove
    {
        [SerializeField]
        public string Name;
        
        [SerializeField]
        public PType MoveType;
        
        [SerializeField]
        public int BasePP;

        public int MaxPP { get; private set; }

        [SerializeField]
        private int ppStage;
        public int PPStage {
            get
            { 
                return ppStage; 
            }
            set
            {
                ppStage = value;
                MaxPP = BasePP + (BasePP / 5 * ppStage);
            } 
        }

        [SerializeField]
        public int Power;

        [SerializeField]
        public int Accuracy;

        [SerializeField]
        public Category MoveCategory;

        [SerializeField]
        public Byte MoveFlags;

        [SerializeField]
        public int CritMod;

        public BaseMove(string name, PType t, Category c, int initPP, int p, int a, int range = 1)
        {
            Name = name;
            MoveType = t;
            MoveCategory = c;
            BasePP = initPP;
            Power = p;
            Accuracy = a;
        }
        
    }
}