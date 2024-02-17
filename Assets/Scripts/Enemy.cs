using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [SerializeField] int startHealth;
    [SerializeField] TextMeshProUGUI healthText;

    int health;

    private void Awake()
    {
        health = startHealth;
        healthText.text = health.ToString();
    }

    public void Damage(WeaponHitInfo hit)
    {
        health -= hit.damage;
        healthText.text = health.ToString();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
