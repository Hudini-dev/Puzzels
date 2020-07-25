using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "PlayerTableData", menuName = "Table/PlayerTableData")]
    public class PlayerTableData : ScriptableObject
    {
        public Sprite[] Houses;
        public int ForgedKeys;
        public int Amber;
        public List<CardData> Archive;
        public List<CardData> Hand;
        public List<CardData> PlayedArtifacts;
        public List<CreatureCardData> PlayedCreatures;
    }
}
