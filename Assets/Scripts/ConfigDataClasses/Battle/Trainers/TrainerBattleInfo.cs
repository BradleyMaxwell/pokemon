using UnityEngine;

public abstract class TrainerBattleInfo : ScriptableObject
{
    [SerializeField]
    protected Pokemon[] pokemonParty = new Pokemon[6];
    public Pokemon[] PokemonParty
    {
        get
        {
            return pokemonParty;
        }
    }

    // counts how many slots in the trainer's party are occupied
    public int GetPokemonPartySize()
    {
        int size = 0;
        foreach (Pokemon slot in PokemonParty)
        {
            if (slot != null)
            {
                size++;
            }
        }

        return size;
    }

    public void AddPokemonToParty(Pokemon newPokemon)
    {
        // find the first empty slot in the party
        for (int slot = 0; slot < PokemonParty.Length; slot++)
        {
            if (PokemonParty[slot] == null)
            {
                pokemonParty[slot] = newPokemon;
            }
        }
    }
}
