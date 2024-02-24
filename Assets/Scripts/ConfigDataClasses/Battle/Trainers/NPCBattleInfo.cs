using UnityEngine;

[CreateAssetMenu(fileName = "NewNPCBattleInfo", menuName = "NPCBattleInfo")]
public class NPCBattleInfo : TrainerBattleInfo
{
    [SerializeField]
    private int currencyReward;

    [SerializeField]
    [TextArea]
    private string defeatDialogue;
}
