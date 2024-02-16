using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanWeapon : Weapon
{
    [SerializeField] ParticleSystem hitParticle;

    public override bool Fire()
    {
        if (!base.Fire()) { return false; }

        HitScanFire();
        return true;
    }
    
    public void HitScanFire()
    {
        Ray weaponRay = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit = new();

        if (Physics.Raycast(weaponRay, out hit, weaponRange, weaponRayMask))
        {
            hitParticle.Play();
            hitParticle.transform.SetParent(null);
            hitParticle.transform.position = hit.point;

            HandleEntityHit(hit);
        }
    }

    private static void HandleEntityHit(RaycastHit hit)
    {
        
    }
}
