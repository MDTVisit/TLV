using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public string playerTag = "Player";
    public float speed = 5f;

    private Transform playerTransform;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogWarning("Could not find object with tag: " + playerTag);
        }
    }

    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }
    }
}






