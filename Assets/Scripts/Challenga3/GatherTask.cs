using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GatherTask : QuestTask
{
    public string itemName;
    public override string GetProgress()
    {
        return $"Gathered: {itemName} - {description}";
    }
}
