using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public virtual void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I - " + collision.gameObject.name + " was hit");
    }
    public virtual void OnCollisionStay(Collision collision)
    {
        
    }

    public virtual void OnCollisionExit(Collision collision)
    {
        
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        
    }

    public virtual void OnTriggerStay(Collider other)
    {
        
    }

    public virtual void OnTriggerExit(Collider other)
    {
        
    }



    //public override void OnCollisionEnter(Collision collision)
    //{
    //    base.OnCollisionEnter(Collider collision);
    //}

    //public override void OnCollisionStay(Collision collision)
    //{
    //    base.OnCollisionStay(Collider collision);
    //}

    //public override void OnCollisionExit(Collision collision)
    //{
    //    base.OnCollisionExit(Collider collision);
    //}

    //public override void OnTriggerEnter(Collider other)
    //{
    //    base.OnTriggerEnter(Collider collision);
    //}

    //public override void OnTriggerStay(Collider other)
    //{
    //    base.OnTriggerStay(Collider collision);
    //}

    //public override void OnTriggerExit(Collider other)
    //{
    //    base.OnTriggerExit(Collider collision);
    //}
}
