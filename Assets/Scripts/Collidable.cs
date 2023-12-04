using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        OnCollision();
    }

    public virtual void OnCollision()
    {

    }
}
