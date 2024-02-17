using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, IDamagable
{
    [SerializeField] int startHealth;
    [SerializeField] TextMeshProUGUI healthText;

    int health;

    private void Awake()
    {
        health = startHealth;
        healthText.text = "Health: " + health + "/" + startHealth;
    }

    public void Damage(WeaponHitInfo hit)
    {
        health -= hit.damage;
        healthText.text = "Health: " + health + "/" + startHealth;

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
