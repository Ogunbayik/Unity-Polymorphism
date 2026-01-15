using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestDataSO : ScriptableObject
{
    [SerializeField] private string _questName;
    [TextArea]
    [SerializeField] private string _description;
    [SerializeField] private string _requiredID;
    [SerializeField] private int _requiredCount;

    public string QuestName => _questName;
    public string RequiredID => _requiredID;
    public string Description => _description;
    public int RequiredCount => _requiredCount;

}
