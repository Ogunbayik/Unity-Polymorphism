using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    [SerializeField] private QuestDataSO _questData;

    public QuestDataSO QuestData => _questData;
}
