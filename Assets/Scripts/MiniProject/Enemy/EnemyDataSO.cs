using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Enemy Data")]
public class EnemyDataSO : ScriptableObject
{
    [Header("Data Settings")]
    [SerializeField] private string _name;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _score;
    [SerializeField] private Color _color;

    public string Name => _name;
    public int MaxHealth => _maxHealth;
    public int Score => _score;
    public Color Color => _color;
}
