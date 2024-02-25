using UnityEngine;

[CreateAssetMenu(fileName = "SingleBattleContext", menuName = "SingleBattleContext")]
public class SingleBattleContext : ScriptableObject
{
    [SerializeField]
    private PlayerBattleInfo playerBattleInfo;

    [SerializeField]
    private NPCBattleInfo opponentBattleInfo;
}
