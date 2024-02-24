using UnityEngine;

public abstract class TrainerBattleInfo : ScriptableObject
{
    [SerializeField]
    private Pokemon[] pokemonParty = new Pokemon[6];
}
