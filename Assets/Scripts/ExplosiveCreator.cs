using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveCreator : Weapon
{
    [SerializeField] GameObject explosiveObject;

    public override bool Fire()
    {
        if (!base.Fire()) { return false; }

        PlaceExplosive();
        return true;
    }

    void PlaceExplosive()
    {
        Instantiate(explosiveObject, transform.position, Quaternion.identity);
    }
}
