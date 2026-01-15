using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class QuestsManager : MonoBehaviour
{
    [SerializeField] private List<QuestStatus> allQuests = new List<QuestStatus>();
    private SignalBus _signalBus;

    [Inject]
    public void Construct(SignalBus signalBus) => _signalBus = signalBus;

    private void OnEnable()
    {
        _signalBus.Subscribe<GameSignal.EnemyKillSignal>(CheckQuestProgress);
        
    }
    private void OnDisable()
    {
        _signalBus.Unsubscribe<GameSignal.EnemyKillSignal>(CheckQuestProgress);
    }
    public void CheckQuestProgress(GameSignal.EnemyKillSignal signal)
    {
        foreach (var quest in allQuests)
        {
            if (quest.Data is KillQuestSO killdata && killdata.RequiredEnemy == signal.KilledEnemy.Data.Name)
            {
                quest.AddProgress(1);
                Debug.Log($"{quest.Data.QuestName}, Progress: {quest.CurrentCount.ToString()}/{quest.Data.RequiredCount.ToString()}");
            }
        }
    }

    public void AddQuest(QuestStatus newQuest)
    {
        if (allQuests.Contains(newQuest))
            Debug.Log($"Player have this {newQuest.Data.QuestName}");

        allQuests.Add(newQuest);
    }

}
