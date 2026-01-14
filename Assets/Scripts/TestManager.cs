using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    private List<Enemy> enemyList = new List<Enemy>();

    void Start()
    {
        GameObject archer = new GameObject();
        GameObject orc = new GameObject();

        archer.AddComponent<Archer>();
        archer.name = "Archer";

        orc.AddComponent<Orc>();
        orc.name = "Orc";

        enemyList.Add(archer.GetComponent<Enemy>());
        enemyList.Add(orc.GetComponent<Enemy>());

        foreach (Enemy enemy in enemyList)
        {
            enemy.Attack();
        }
    }
}
