using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public abstract class EnemyBase : MonoBehaviour
{
    protected const int testDamage = 7;

    private EnemyDataSO _enemyData;

    protected SignalBus _signalBus;

    private MeshRenderer _meshRenderer;

    protected int _currentHealth;

    [Inject]
    protected void Construct(EnemyDataSO enemyData, SignalBus signalBus)
    {
        _enemyData = enemyData;
        _signalBus = signalBus;
        _currentHealth = enemyData.MaxHealth;
    }

    [Header("UI Settings")]
    [SerializeField] private TextMeshProUGUI _nameText;
    private void Awake() => _meshRenderer = GetComponentInChildren<MeshRenderer>();
    private void Start() => InitializeEnemy();

    private void InitializeEnemy()
    {
        _meshRenderer.material.color = _enemyData.Color;
        _nameText.text = _enemyData.Name;
        _nameText.color = _enemyData.Color;
    }
    private void OnMouseDown()
    {
        TakeDamage(testDamage);
        Debug.Log($"{_enemyData.Name} Health: {_currentHealth}");
    }

    public void TakeDamage(int damageAmount)
    {
        _currentHealth -= damageAmount;

        if (_currentHealth <= 0)
        {
            _signalBus.Fire(new GameSignal.EnemyKillSignal(this));
            _currentHealth = 0;
            Destroy(this.gameObject);
        }
    }

    public EnemyDataSO Data => _enemyData;
}

public enum EnemyType
{
    Skeleton,
    Zombie,
    Goblin
}
