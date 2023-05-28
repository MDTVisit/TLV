using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else if (hitInfo.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
