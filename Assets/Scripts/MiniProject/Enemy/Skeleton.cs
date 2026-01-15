using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Skeleton : EnemyBase
{
    public class Factory : PlaceholderFactory<EnemyDataSO,Skeleton> { }
}
