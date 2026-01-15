using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class KillTask : QuestTask
{
    public int killCount;
    public override string GetProgress()
    {
        return $"Killcount: {killCount} - {description}";
    }
}
