using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonSpecies", menuName = "PokemonSpecies")]
public class PokemonSpecies : ScriptableObject
{
    [SerializeField]
    private new string name;

    [SerializeField]
    private string tag; // shows in the pokedex as "The ____ Pokemon"

    [SerializeField]
    private List<PokemonType> type;

    [SerializeField]
    private int heightFeet;

    [SerializeField]
    [Range(0, 11)]
    private int heightInches;

    [SerializeField]
    private float weight; // in lbs

    [SerializeField]
    [TextArea]
    private string description;

    [SerializeField]
    private BattleStats baseStats;
    public BattleStats BaseStats
    {
        get
        {
            return baseStats;
        }
    }
}
