using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject projectileObject;
    [SerializeField] GameObject detonationObject;

    [SerializeField] float detonationLifeTime;
    protected float detonationTime;

    protected Vector3 spawnPosition;
    protected Vector3 aimPosition;
    protected Vector3 aimDirection;

    public float movementSpeed;

    public virtual void Init(Vector3 aSpawnPosition, Vector3 anAimPosition)
    {
        spawnPosition = aSpawnPosition;
        aimPosition = anAimPosition;
        aimDirection = aimPosition - spawnPosition;

        gameObject.transform.position = spawnPosition;
        gameObject.transform.LookAt(aimDirection, transform.up);
    }

    private void Start()
    {
        projectileObject.SetActive(true);
        detonationObject.SetActive(false);
    }

    public virtual void Update()
    {
        if(detonationTime > 0)
        {
            detonationTime -= Time.deltaTime;
            Debug.Log(detonationTime);
        }
        if (detonationTime < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player")
        {
            projectileObject.SetActive(false);
            detonationObject.SetActive(true);
        }
    }
}
