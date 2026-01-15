using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Quest Data/Kill Quest")]
public class KillQuestSO : QuestDataSO
{
    [Header("Kill Settings")]
    [SerializeField] private string _requiredEnemy;

    public string RequiredEnemy => _requiredEnemy;
}
