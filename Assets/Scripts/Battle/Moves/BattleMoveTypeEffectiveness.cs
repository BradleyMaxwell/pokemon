using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBattleMoveTypeEffectiveness", menuName = "Battle/MoveTypeEffectiveness")]
public class BattleMoveTypeEffectiveness : ScriptableObject
{
    [SerializeField]
    private List<PokemonType> superEffective;
    [SerializeField]
    private List<PokemonType> notVeryEffective;
    [SerializeField]
    private List<PokemonType> noEffect;
}
