using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rb;

    private const int bulletDamage = 10;
    private const float bulletForce = 5f;

    private void Awake() => _rb = GetComponent<Rigidbody>();
    private void Start() => _rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IDamageable>(out IDamageable damageable))
        {
            damageable.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}
