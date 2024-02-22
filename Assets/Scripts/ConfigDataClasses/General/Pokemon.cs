using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemon", menuName = "Pokemon")]
public class Pokemon : ScriptableObject
{
    [SerializeField]
    private PokemonSpecies pokemonSpecies;

    [SerializeField]
    private string nickname;

    [SerializeField]
    private Gender gender;

    [SerializeField]
    private PokemonLevelInfo pokemonLevelInfo;

    [SerializeField]
    private BattleMove[] battleMoves = new BattleMove[4]; // pokemon can never have more than 4 moves in their move set
}
