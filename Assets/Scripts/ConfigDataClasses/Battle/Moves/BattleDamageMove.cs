using UnityEngine;

public enum DamageCategories
{
    Physical,
    Special
}

[CreateAssetMenu(fileName = "NewBattleDamageMove", menuName = "Battle/Move/DamageMove")]
public class BattleDamageMove : BattleMove
{
    [SerializeField]
    private int power;
    [SerializeField]
    private DamageCategories damageCategory;
}
