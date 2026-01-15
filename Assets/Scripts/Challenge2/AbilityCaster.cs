using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCaster : MonoBehaviour
{
    [SerializeField] private Ability _currentAbility;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _currentAbility != null)
        {
            _currentAbility.Use(this.gameObject);
        }
    }
}
