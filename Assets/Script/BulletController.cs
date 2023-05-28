using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private int damage;

    public void SetDamage(int value)
    {
        damage = value;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HP playerHealth = other.GetComponent<HP>();
            playerHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

