using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _minimumXRange;
    [SerializeField] private float _maximumXRange;
    [SerializeField] private float _spawnInterval;

    private void Start() => InvokeRepeating(nameof(CreateBullet),_spawnInterval, _spawnInterval);

    private void CreateBullet()
    {
        var randomX = Random.Range(_minimumXRange, _maximumXRange);
        var bullet = Instantiate(_bulletPrefab);

        bullet.transform.position = new Vector3(randomX, 0.5f, 0f);
    }

}
