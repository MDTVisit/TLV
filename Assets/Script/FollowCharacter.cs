using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public Transform characterTransform;

    public float speed = 1.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - characterTransform.position;
    }

    void LateUpdate()
    {
        float x = characterTransform.position.x;
        float y = characterTransform.position.y;
        Vector3 targetPosition = new Vector3(x, y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition + offset, speed * Time.deltaTime);
    }
}
