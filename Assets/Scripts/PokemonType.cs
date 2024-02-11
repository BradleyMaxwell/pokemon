using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonType", menuName = "PokemonType")]
public class PokemonType : ScriptableObject
{
    [SerializeField]
    private string typeName;
    [SerializeField]
    private Color typeColor;
    [SerializeField]
    private BattleMoveTypeEffectiveness moveTypeEffectiveness;
}
