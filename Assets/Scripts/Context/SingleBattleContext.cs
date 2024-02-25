using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SingleBattleContext", menuName = "SingleBattleContext")]
public class SingleBattleContext : ScriptableObject
{
    [SerializeField]
    private PlayerBattleInfo playerBattleInfo;
    public PlayerBattleInfo PlayerBattleInfo
    {
        get
        {
            return playerBattleInfo;
        }
    }

    [SerializeField]
    private NPCBattleInfo opponentBattleInfo;
    public NPCBattleInfo OpponentBattleInfo
    {
        get
        {
            return opponentBattleInfo;
        }
    }

    [SerializeField]
    private Pokemon playerActivePokemon;
    public Pokemon PlayerActivePokemon
    {
        get
        {
            return playerActivePokemon;
        }
        set
        {
            playerActivePokemon = value;
            if (IsPokemonInTrainerParty(value, playerBattleInfo))
            {
                playerActivePokemon = value;
            }
            else
            {
                Debug.LogError($"The player does not have that pokemon in their party.");
            }
        }
    }

    [SerializeField]
    private Pokemon opponentActivePokemon;
    public Pokemon OpponentActivePokemon
    {
        get
        {
            return opponentActivePokemon;
        }
        set
        {
            if (IsPokemonInTrainerParty(value, opponentBattleInfo))
            {
                opponentActivePokemon = value;
            }
            else
            {
                Debug.LogError($"The opponent does not have {value.name} in their party.");
            }
        }
    }

    [SerializeField]
    private Dictionary<BattleStat, int> opponentActivePokemonStatStages;

    private bool IsPokemonInTrainerParty(Pokemon pokemon, TrainerBattleInfo trainerBattleInfo)
    {
        if (Array.IndexOf(trainerBattleInfo.PokemonParty, pokemon) >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
