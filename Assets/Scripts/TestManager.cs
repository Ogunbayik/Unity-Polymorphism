using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    void Start()
    {
        GameObject archer = new GameObject();
        GameObject orc = new GameObject();

        archer.AddComponent<Archer>();
        orc.AddComponent<Orc>();

        archer.GetComponent<Archer>().Attack();
        orc.GetComponent<Orc>().Attack();
    }
}
