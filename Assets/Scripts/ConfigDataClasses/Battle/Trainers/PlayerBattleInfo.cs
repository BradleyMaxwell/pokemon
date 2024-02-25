using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerBattleInfo", menuName = "PlayerBattleInfo")]
public class PlayerBattleInfo : TrainerBattleInfo
{
    public void SwapPartyPosition(int partySlot1, int partySlot2)
    {
        Pokemon[] pokemonPartyCopy = PokemonParty;

        Pokemon tempPokemon = pokemonPartyCopy[partySlot1];
        pokemonPartyCopy[partySlot1] = pokemonPartyCopy[partySlot2];
        pokemonPartyCopy[partySlot2] = tempPokemon;

        pokemonParty = pokemonPartyCopy;
    }
}
