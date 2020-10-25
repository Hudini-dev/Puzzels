using Assets.Scripts.Data;
using System;
using System.Collections.Generic;

[Serializable]
public class PlayerBoardData
{
    public Expansions Expansion;
    public string[] Houses;
    public int ForgedKeys;
    public int Amber;
    public int Chains;
    public List<BaseCardData> PlayedEffects;
    public List<BaseCardData> Deck;
    public List<BaseCardData> Archive;
    public List<BaseCardData> Discard;
    public List<BaseCardData> Hand;
    public List<ArtifactCardData> PlayedArtifacts;
    public List<CreatureCardData> PlayedCreatures;
}
