using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int maxHealth = 2; 
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth; 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        if (currentHealth <= 0) 
        {
            Destroy(gameObject); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HP playerHealth = collision.gameObject.GetComponent<HP>(); 
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }

            TakeDamage(1); 
        }
    }
}
