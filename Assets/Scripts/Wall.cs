using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damageAmount) => Debug.Log($"Bullet hit the wall!");

}
