using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Weapon creator;

    [SerializeField] GameObject projectileObject;
    [SerializeField] GameObject detonationObject;

    [SerializeField] float detonationLifeTime;
    [SerializeField] float timeWithoutCollider;
    protected float detonationTime;
    protected bool hasExploded;

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

        detonationTime = detonationLifeTime;
    }

    public virtual void Update()
    {
        if(detonationTime >= detonationLifeTime - timeWithoutCollider)
        {
            projectileObject.GetComponent<Collider>().enabled = false;
        }
        else
        {
            projectileObject.GetComponent<Collider>().enabled = true;
        }
        if(detonationTime > 0)
        {
            detonationTime -= Time.deltaTime;
        }
        if (detonationTime <= 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        var hitAgent = other.gameObject.GetComponent<Agent>();
        if (hitAgent != null)
        {
            //DU SKA TA SKADA!!!!
        }

        if(other.gameObject.tag != "Player")
        {
            hasExploded = true;
            detonationTime = 1;
            projectileObject.SetActive(false);
            detonationObject.SetActive(true);
            PlayerUIManager.GlobalPlayerData.lastObjectHit = other.gameObject.name;
        }
    }
}
