using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBattleStats", menuName = "Battle/Stats")]
public class BattleStats : ScriptableObject
{
    [SerializeField]
    private int hitPoints;

    [SerializeField]
    private int attack;

    [SerializeField]
    private int defense;

    [SerializeField]
    private int specialAttack;

    [SerializeField]
    private int specialDefense;

    [SerializeField]
    private int speed;

    [SerializeField]
    private int evasiveness;
}
