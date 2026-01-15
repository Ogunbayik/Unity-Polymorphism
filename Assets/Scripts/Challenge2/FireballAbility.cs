using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Fireball")]
public class FireballAbility : Ability
{
    public override void Use(GameObject user) => Debug.Log($"{user.name} is using Fireball Ability!");
}
