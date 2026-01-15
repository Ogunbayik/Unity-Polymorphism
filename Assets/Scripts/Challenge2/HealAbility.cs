using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Heal Ability")]
public class HealAbility : Ability
{
    public override void Use(GameObject user) => Debug.Log($"{user.name} is using HEAL Ability..Recovering..");
}
