using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int ammunition;
    public LayerMask weaponRayMask;
    public float weaponRange;
    public int damage;

    public virtual bool Fire()
    {
        if (ammunition < 1)
        {
            return false;
        }
        else
        {
            ammunition--;
            PlayerUIManager.GlobalPlayerData.ammo = ammunition;
            return true;
        }
    }
}

[Serializable]
public struct WeaponHitInfo
{
    public int damage;

    public WeaponHitInfo(int damage)
    {
        this.damage = damage;
    }
}
