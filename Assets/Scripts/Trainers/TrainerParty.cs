using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class TrainerParty
{
    [SerializeField]
    private List<Pokemon> _pokemonParty = new List<Pokemon>();
    public List<Pokemon> PokemonParty
    {
        get { return _pokemonParty; }
    }

    public void AddPokemonToParty(Pokemon pokemon)
    {
        if (_pokemonParty.Count == 6)
        {
            Debug.LogError("party is at full capacity");
            return;
        }

        if (_pokemonParty.Any(partyPokemon => Guid.Equals(partyPokemon.Id, pokemon.Id)))
        {
            Debug.LogError($"that instance of {pokemon.Species.Name} is already in the party");
            return;
        }

        _pokemonParty.Add(pokemon);
    }
}
