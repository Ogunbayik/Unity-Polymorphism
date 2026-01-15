using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Zombie : EnemyBase
{
    public class Factory : PlaceholderFactory<EnemyDataSO,Zombie> { }
}
