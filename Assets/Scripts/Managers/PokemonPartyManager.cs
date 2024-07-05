using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PokemonPartyManager : Singleton<PokemonPartyManager>
{
    public TrainerParty PlayerParty { get; private set; }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        PlayerParty = new TrainerParty();
    }
}
