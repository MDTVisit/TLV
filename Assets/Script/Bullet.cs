using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int damage = 1; 
    public void SetDamage(int amount)
    {
        damage = amount; 
    }

    public int GetDamage()
    {
        return damage; 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            Score.scoreValue += 5;
            hitInfo.GetComponent<Enemy>().TakeDamage(damage); 
        }
    }
}

