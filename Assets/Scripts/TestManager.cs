using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    private List<Enemy> enemyList = new List<Enemy>();

    private const int testDamage = 10;

    void Start()
    {
        GameObject archer = new GameObject();
        GameObject orc = new GameObject();

        archer.AddComponent<Archer>();
        archer.name = "Archer";

        orc.AddComponent<Orc>();
        orc.name = "Orc";

        enemyList.Add(archer.GetComponent<Archer>());
        enemyList.Add(orc.GetComponent<Orc>());

        foreach (Enemy enemy in enemyList)
        {
            enemy.TakeDamage(testDamage);
        }
    }
}
