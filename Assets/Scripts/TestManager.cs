using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    private List<IDamageable> damageableList = new List<IDamageable>();

    private const int testDamage = 10;

    void Start()
    {/*
        GameObject archer = new GameObject();
        GameObject orc = new GameObject();
        GameObject crate = new GameObject();

        archer.AddComponent<Archer>();
        archer.name = "Archer";

        orc.AddComponent<Orc>();
        orc.name = "Orc";

        crate.AddComponent<Crate>();
        crate.name = "Crate";

        damageableList.Add(archer.GetComponent<Archer>());
        damageableList.Add(orc.GetComponent<Orc>());
        damageableList.Add(crate.GetComponent<Crate>());

        foreach (IDamageable damageableObj in damageableList)
        {
            damageableObj.TakeDamage(testDamage);
        }
        */
    }
}
