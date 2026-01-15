using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damageAmount) => Debug.Log($"Crate took {damageAmount} damage.. Crate is destroyed!");
}
