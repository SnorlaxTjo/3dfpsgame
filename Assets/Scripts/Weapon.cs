using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int ammunition;
    public LayerMask weaponRayMask;
    public float weaponRange;

    public virtual bool Fire()
    {
        if (ammunition < 1)
        {
            return false;
        }
        else
        {
            ammunition--;
            return true;
        }
    }
}
