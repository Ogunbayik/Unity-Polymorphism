using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Enemy
{
    public override void Attack()
    {
        Debug.Log("Archer is using bow");
    }

    public override void TakeDamage(int damageAmount) => Debug.Log($"Archer took {damageAmount} damage.. Archer is retreating..");
}
