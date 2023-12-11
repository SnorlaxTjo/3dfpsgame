using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Projectile
{
    public override void Init(Vector3 aSpawnPosition, Vector3 anAimPosition)
    {
        base.Init(aSpawnPosition, anAimPosition);
    }

    public override void Update()
    {
        base.Update();
        if (base.detonationTime < 0 || base.hasExploded)
        {
            return;
        }
        transform.position += aimDirection.normalized * movementSpeed * Time.deltaTime;
    }
}
