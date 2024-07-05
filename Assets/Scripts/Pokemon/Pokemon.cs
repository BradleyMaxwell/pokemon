using System;
using UnityEngine;

// an instance of a pokemon species
[Serializable]
public class Pokemon
{
    [SerializeField]
    private Guid _id;
    public Guid Id
    {
        get { return _id; }
    }

    [SerializeField]
    private PokemonSpecies _species;
    public PokemonSpecies Species
    {
        get { return _species; }
    }

    public Pokemon(PokemonSpecies species)
    {
        _id = Guid.NewGuid();
        _species = species;
    }
}
