using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonSpecies", menuName = "PokemonSpecies")]
public class PokemonSpecies : ScriptableObject
{
    [SerializeField]
    private string _name;
    public string Name
    {
        get { return _name; }
    }

    [SerializeField]
    [TextArea]
    private string _description;
    public string Description
    {
        get { return _description; }
    }

    #region GenderPossibilities
    private Dictionary<Gender, float> _genderPossibilities;
    public Dictionary<Gender, float> GenderPossibilities
    {
        set
        {
            float totalPercent = 0;
            foreach(KeyValuePair<Gender, float> genderPossibility in value)
            {
                totalPercent += genderPossibility.Value;
            }
            if (totalPercent == 1)
            {
                _genderPossibilities = value;
            }
            else
            {
                Debug.LogError($"Gender possibilities values must total to 1. {Name} totals to {totalPercent}");
            }
        }
    }
    #endregion

    [SerializeField]
    private BattleStats _baseStats;
    public BattleStats BaseStats
    {
        get { return _baseStats; }
    }
}
