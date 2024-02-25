using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemon", menuName = "Pokemon")]
public class Pokemon : ScriptableObject
{
    [SerializeField]
    private PokemonSpecies pokemonSpecies;

    [SerializeField]
    private string nickname;
    public string Nickname
    {
        get
        {
            return nickname;
        }
    }

    [SerializeField]
    private Gender gender;

    [SerializeField]
    private PokemonLevelInfo pokemonLevelInfo;

    [SerializeField]
    private BattleMove[] battleMoves = new BattleMove[4]; // pokemon can never have more than 4 moves in their move set

    // pokemon stats are calculated every time the getter is called
    private BattleStats battleStats => GetStats();
    public BattleStats BattleStats
    {
        get
        {
            return battleStats;
        }
    }

    public BattleStats GetStats()
    {
        BattleStats stats = new()
        {
            HitPoints = BattleStats.CalculateHitPoints(pokemonSpecies.BaseStats.HitPoints, pokemonLevelInfo.Level),
            Attack = BattleStats.CalculateStat(pokemonSpecies.BaseStats.Attack, pokemonLevelInfo.Level),
            Defense = BattleStats.CalculateStat(pokemonSpecies.BaseStats.Defense, pokemonLevelInfo.Level),
            SpecialAttack = BattleStats.CalculateStat(pokemonSpecies.BaseStats.SpecialAttack, pokemonLevelInfo.Level),
            SpecialDefense = BattleStats.CalculateStat(pokemonSpecies.BaseStats.SpecialDefense, pokemonLevelInfo.Level),
            Speed = BattleStats.CalculateStat(pokemonSpecies.BaseStats.Speed, pokemonLevelInfo.Level)
        };

        return stats;
    }
}
