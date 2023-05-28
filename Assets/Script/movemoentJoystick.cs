using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemoentJoystick : MonoBehaviour
{

    public Joystick joystick;
    public int moveSpeed;
    public Rigidbody2D rb;
    public bool ConFisicas;
    void Start()
    {

    }



    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical  + Vector2.right * joystick.Horizontal;
        if(ConFisicas)
        {
            rb.AddForce(direction * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse );

        }
        else
        {
            gameObject.transform.Translate(direction * moveSpeed * Time.deltaTime);

        }
    }
}


