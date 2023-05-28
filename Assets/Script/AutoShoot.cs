using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float fireRate; 
    public float bulletSpeed; 
    public int bulletDamage;
    public float spiralFrequency; 

    private float fireDelay; 
    private float angle = 0f; 
    void Start()
    {
        fireDelay = 1 / fireRate; 
        InvokeRepeating("Shoot", 0f, fireDelay); 
    }

    void Shoot()
    {
        angle += spiralFrequency * Time.deltaTime; 
        float x = -Mathf.Cos(angle);
        float y = -Mathf.Sin(angle);

        Vector2 direction = new Vector2(x, y); 
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); 
        Bullet bulletScript = bullet.GetComponent<Bullet>(); 
        bulletScript.SetDamage(bulletDamage);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); 
        rb.gravityScale = 0f;
        rb.velocity = direction * bulletSpeed; 
    }
}

