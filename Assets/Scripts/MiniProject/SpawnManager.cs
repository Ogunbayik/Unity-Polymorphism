using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SpawnManager : MonoBehaviour
{
    private EnemyFactory _enemyFactory;
    [Header("Border Settings")]
    [SerializeField] private float _spawnRange;
    [Header("Enemy Data Settings")]
    [SerializeField] private EnemyDataSO _skeletonData;
    [SerializeField] private EnemyDataSO _goblinData;
    [SerializeField] private EnemyDataSO _zombieData;
    [Header("Enemy Button Setting")]
    [SerializeField] private Button _skeletonButton;
    [SerializeField] private Button _goblinButton;
    [SerializeField] private Button _zombieButton;

    [Inject]
    public void Construct(EnemyFactory enemyFactory) => _enemyFactory = enemyFactory;

    private void Start()
    {
        InitializeUI();

        _skeletonButton.onClick.AddListener(() => SpawnEnemy(EnemyType.Skeleton, _skeletonData));
        _goblinButton.onClick.AddListener(() => SpawnEnemy(EnemyType.Goblin, _goblinData));
        _zombieButton.onClick.AddListener(() => SpawnEnemy(EnemyType.Zombie, _zombieData));
    }
    private void InitializeUI()
    {
        SetButtonColor(_skeletonButton, _skeletonData);
        SetButtonColor(_zombieButton, _zombieData);
        SetButtonColor(_goblinButton, _goblinData);
    }
    private void SetButtonColor(Button button,EnemyDataSO data)
    {
        ColorBlock buttonColors = button.colors;
        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

        buttonColors.normalColor = data.Color;
        buttonColors.pressedColor = data.Color;
        buttonColors.selectedColor = data.Color;

        var higlightColor = buttonColors.highlightedColor;
        higlightColor = data.Color;
        higlightColor.a = 0.6f;

        buttonColors.highlightedColor = higlightColor;

        button.colors = buttonColors;

        button.navigation = new Navigation { mode = Navigation.Mode.None };

        buttonText.text = data.Name;
        buttonText.color = Color.white;
    }
    public void SpawnEnemy(EnemyType type,EnemyDataSO data)
    {
        var enemy = _enemyFactory.Create(type, data);
        enemy.transform.position = GetRandomPosition();
    }

    private Vector3 GetRandomPosition()
    {
        var randomX = Random.Range(-_spawnRange, _spawnRange);
        var randomZ = Random.Range(-_spawnRange, _spawnRange);
        var randomPosition = new Vector3(randomX, 0f, randomZ);

        return randomPosition;
    }



}
