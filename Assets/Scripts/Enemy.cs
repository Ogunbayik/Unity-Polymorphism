using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    public virtual void Attack()
    {

    }

    public abstract void TakeDamage(int damageAmount);
}
