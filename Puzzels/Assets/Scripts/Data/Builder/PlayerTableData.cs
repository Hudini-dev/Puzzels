using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data.Builder
{
    [CreateAssetMenu(fileName = "PlayerTableData", menuName = "Table/PlayerTableData")]
    public class PlayerTableData : ScriptableObject
    {
        public Expansions Expansion;
        public Houses[] Houses;
        public int ForgedKeys;
        public int Amber;
        public int Chanis;
        public List<CardData> PlayedEffects;
        public List<CardData> Deck;
        public List<CardData> Archive;
        public List<CardData> Discard;
        public List<CardData> Hand;
        public List<CardData> PlayedArtifacts;
        public List<CreatureCardData> PlayedCreatures;
    }
}
