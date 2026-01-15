using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSignal
{

    public class EnemyKillSignal
    {
        public EnemyBase Enemy;

        public EnemyKillSignal(EnemyBase enemy) { Enemy = enemy; }

    }
}
