using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSignal
{

    public class EnemyKillSignal
    {
        public EnemyBase KilledEnemy;

        public EnemyKillSignal(EnemyBase killedEnemy) { KilledEnemy = killedEnemy; }

    }
}
