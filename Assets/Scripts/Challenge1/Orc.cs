using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{

    public override void Attack()
    {
        Debug.Log("Orc Swinging his axe");
    }

    public override void TakeDamage(int damageAmount) => Debug.Log($"Orc took {damageAmount} damage.. Orc is agressive mood.");
}
