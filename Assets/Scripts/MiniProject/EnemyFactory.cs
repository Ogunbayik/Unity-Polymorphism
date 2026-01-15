using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyFactory 
{
    private Dictionary<EnemyType, IFactory<EnemyDataSO, EnemyBase>> _enemyMap = new Dictionary<EnemyType, IFactory<EnemyDataSO, EnemyBase>>();

    public EnemyFactory(Skeleton.Factory skeletonFactory, Zombie.Factory zombieFactory, Goblin.Factory goblinFactory)
    {
        _enemyMap.Add(EnemyType.Skeleton, skeletonFactory);
        _enemyMap.Add(EnemyType.Zombie, zombieFactory);
        _enemyMap.Add(EnemyType.Goblin, goblinFactory);
    }

    public EnemyBase Create(EnemyType type, EnemyDataSO data)
    {
        if (_enemyMap.TryGetValue(type, out var enemyFactory))
            return enemyFactory.Create(data);

        throw new System.ArgumentOutOfRangeException(nameof(type), type, "Bu düþman türü Factory içerisinde tanýmlanmamýþ.");
    }
}
