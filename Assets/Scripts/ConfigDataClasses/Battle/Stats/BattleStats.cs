using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBattleStats", menuName = "Battle/Stats")]
public class BattleStats : ScriptableObject
{
    [SerializeField]
    private int hitPoints;
    public int HitPoints
    {
        get
        {
            return hitPoints;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(HitPoints)} cannot be lower than 1 so it has been set to 1.");
                hitPoints = 1;
            }
            else
            {
                hitPoints = value;
            }
        }
    }

    [SerializeField]
    private int attack;
    public int Attack
    {
        get
        {
            return attack;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(Attack)} cannot be lower than 1 so it has been set to 1.");
                hitPoints = 1;
            }
            else
            {
                hitPoints = value;
            }
        }
    }

    [SerializeField]
    private int defense;
    public int Defense
    {
        get
        {
            return defense;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(Defense)} cannot be lower than 1 so it has been set to 1.");
                defense = 1;
            }
            else
            {
                defense = value;
            }
        }
    }

    [SerializeField]
    private int specialAttack;
    public int SpecialAttack
    {
        get
        {
            return specialAttack;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(SpecialAttack)} cannot be lower than 1 so it has been set to 1.");
                specialAttack = 1;
            }
            else
            {
                specialAttack = value;
            }
        }
    }

    [SerializeField]
    private int specialDefense;
    public int SpecialDefense
    {
        get
        {
            return specialDefense;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(SpecialDefense)} cannot be lower than 1 so it has been set to 1.");
                specialDefense = 1;
            }
            else
            {
                specialDefense = value;
            }
        }
    }

    [SerializeField]
    private int speed;
    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if (value < 1)
            {
                Debug.LogWarning($"{nameof(Speed)} cannot be lower than 1 so it has been set to 1.");
                speed = 1;
            }
            else
            {
                speed = value;
            }
        }
    }

    // hp has a different calculation formula to the other stats
    public static int CalculateHitPoints(int baseHealth, int level)
    {
        return 2 * baseHealth / 100 * level + level + 10;
    }

    public static int CalculateStat(int baseStat, int level)
    {
        return 2 * baseStat / 100 * level + 5;
    }
}
