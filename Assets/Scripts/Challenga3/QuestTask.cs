using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class QuestTask 
{
    [TextArea] public string description;
    public abstract string GetProgress();
}
