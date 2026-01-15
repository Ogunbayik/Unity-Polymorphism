using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestStatus 
{
    private QuestDataSO _questData;
    private int _currentCount;

    private bool _isComplete;
    public QuestStatus(QuestDataSO data)
    {
        _questData = data;

        _currentCount = 0;
        _isComplete = false;
    }

    public void AddProgress(int amount)
    {
        if (_isComplete)
            return;
        
        _currentCount++;

        if (_currentCount >= _questData.RequiredCount)
            _isComplete = true;
    }
    public int CurrentCount => _currentCount;
    public QuestDataSO Data => _questData;
    public bool IsComplete => _isComplete;
}
