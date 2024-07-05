using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// defining an instance of a battle against a specific npc trainer
// this is so we can build modular battles against the same trainer at different points
// in the game i.e. rival battles
[CreateAssetMenu(fileName = "NewNpcTrainerEncounter", menuName = "NpcTrainerEncounter")]
public class NpcTrainerEncounter : ScriptableObject
{
    [SerializeField]
    private NpcTrainer _trainer;
    public NpcTrainer Trainer 
    {
        get { return _trainer; }
    }

    [SerializeField]
    private TrainerParty _trainerParty;
    public TrainerParty TrainerParty
    {
        get { return _trainerParty; }
    }

    [SerializeField]
    private int _winReward;
    public int WinReward
    {
        get { return _winReward; }
    }

    [SerializeField]
    private List<string> _winDialogue;
    public List<string> WinDialogue
    {
        get { return _winDialogue; }
    }
}
