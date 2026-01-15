using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    [SerializeField] private GameObject _skeletonPrefab;
    [SerializeField] private GameObject _zombiePrefab;
    [SerializeField] private GameObject _goblinPrefab;
    public override void InstallBindings()
    {
        //Enemy Factories
        Container.BindFactory<EnemyDataSO,Skeleton, Skeleton.Factory>()
            .FromComponentInNewPrefab(_skeletonPrefab)
            .AsCached();
        Container.BindFactory<EnemyDataSO,Goblin, Goblin.Factory>()
            .FromComponentInNewPrefab(_goblinPrefab)
            .AsCached();
        Container.BindFactory<EnemyDataSO,Zombie, Zombie.Factory>()
            .FromComponentInNewPrefab(_zombiePrefab)
            .AsCached();

        Container.Bind<SpawnManager>().FromComponentInHierarchy().AsSingle();
        Container.Bind<EnemyDataSO>().AsCached();
        Container.Bind<EnemyFactory>().AsSingle();
    }
}