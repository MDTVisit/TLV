using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public GameManagerScript gameManager;
    public int health = 1;
    private bool isDie;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0 && !isDie)
        {
            isDie = true;
            Die();
            gameManager.gameOver();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
