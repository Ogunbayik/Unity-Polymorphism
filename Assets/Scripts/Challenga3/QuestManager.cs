using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [SerializeReference]
    public List<QuestTask> allTasks = new List<QuestTask>();

    private void Start()
    {
        foreach (QuestTask task in allTasks)
        {
            if (task != null)
                Debug.Log(task.GetProgress());
        }
    }

    [ContextMenu("Add Kill Task")]
    private void AddKillTask()
    {
        allTasks.Add(new KillTask());
    }
    [ContextMenu("Add Gather Task")]
    private void AddGatherTask()
    {
        allTasks.Add(new GatherTask());
    }
    [ContextMenu("Clear All Tasks")]
    private void ClearTasks()
    {
        allTasks.Clear();
    }

}
