using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : Weapon
{
    [SerializeField] Projectile spawnProjectile;

    public override bool Fire()
    {
        if (!base.Fire())
        {
            return false;
        }

        Projectile firedProjectile = Instantiate(spawnProjectile);
        firedProjectile.Init(Camera.main.transform.position,
            Camera.main.transform.forward.normalized + Camera.main.transform.position);

        return true;
    }
}
