using UnityEngine;

public abstract class BattleMove : ScriptableObject
{
    [SerializeField]
    private string moveName;
    [SerializeField]
    private PokemonType moveType;
    [SerializeField]
    private int PowerPoints; // the default max amount of times a pokemon can use this move without any modifiers
    [SerializeField]
    [TextArea]
    private string Description;
    [SerializeField]
    private BattleMoveAccuracy Accuracy;
}
