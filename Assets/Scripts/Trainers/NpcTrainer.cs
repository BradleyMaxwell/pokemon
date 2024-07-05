using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNpcTrainer", menuName = "NpcTrainer")]
public class NpcTrainer : Trainer
{
    [SerializeField]
    private string _title;
    public string Title
    {
        get { return _title; }
    }

    [SerializeField]
    private NpcTrainerTitleAffix _titleAffix;
    public NpcTrainerTitleAffix TitleAffix
    {
        get { return _titleAffix; }
    }
}

public enum NpcTrainerTitleAffix
{
    Prefix,
    Suffix
}
