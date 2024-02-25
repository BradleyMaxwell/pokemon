using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleStat
{
    Attack,
    Defense,
    SpecialAttack,
    SpecialDefense,
    Speed,
    Accuracy,
    Evasiveness
}

// the percent change per stage increase/decrease is different for some battle stats
public class BattleStatModifierStages : ScriptableObject
{
    // battle stats can only be increased/dec
    int[] stageModifiers = new int[6];
}
