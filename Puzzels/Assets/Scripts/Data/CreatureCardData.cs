using System;
using System.Collections.Generic;

namespace Assets.Scripts.Data
{
    [Serializable]
    public class CreatureCardData : BaseCardData
    {
        public bool Taunt;
        public bool Stun;
        public bool Ward;
        public bool Enrage;
        public int Damage;
        public int Amber;
        public int Power;
        public List<BaseCardData> Upgrades;
        public bool CardUnder;
    }
}

