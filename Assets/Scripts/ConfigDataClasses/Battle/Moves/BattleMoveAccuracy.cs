using UnityEngine;

[System.Serializable]
public class BattleMoveAccuracy
{
    [SerializeField]
    private bool alwaysHits;
    [SerializeField]
    [Range(0, 100)]
    private int percentChance;
}
