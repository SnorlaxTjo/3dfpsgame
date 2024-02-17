using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : Weapon
{
    [SerializeField] float timeBeforeExplosion;
    [SerializeField] float explosionLength;

    float timeLeft;

    private void Awake()
    {
        timeLeft = timeBeforeExplosion;
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        var hits = Physics.OverlapSphere(transform.position, explosionLength);
        foreach (var hit in hits)
        {
            if (hit.TryGetComponent<IDamagable>(out var entity))
            {
                entity.Damage(new WeaponHitInfo(damage));
            }
        }

        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosionLength);
    }
}
