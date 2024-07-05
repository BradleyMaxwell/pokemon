using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// used to pass in context to the battle scene from other scenes
public class BattleContext : Singleton<BattleContext>
{
    public TrainerParty PlayerParty { get; set; }
    public TrainerParty OpponentParty { get; set; }
    public NpcTrainer OpponentTrainer { get; set; }
    public bool IsTrainerBattle => OpponentTrainer != null;
    
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
