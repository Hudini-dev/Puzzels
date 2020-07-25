using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [Serializable]
    public class CreatureCardData: CardData
    {
        public bool Taunt;
        public bool Stun;
        public bool Ward;
        public bool Enrage;
        public int Damage;
        public int Amber;
        public int Power;
        public List<CardData> Upgrades;
        public bool CardUnder;
    }
}
