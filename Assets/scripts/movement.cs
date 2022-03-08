using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class movement : MonoBehaviour
{
    public float speed;
    public float jumpStrength;
    public float jumpKill = 2f;
    public Vector3 gravity;
    public float weerstand = 2;

    //HAAL MIJ STRAKS OOK WEG
    public Vector3 addBoi;



    private CharacterController controller;
    private Vector3 velocity = Vector3.zero;
    private float jumpForce = 0f;
    private float jumpBuffer = 0f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpBuffer = 0.1f;
        }
        if(jumpBuffer >= 0)
        {
            jumpBuffer -= Time.deltaTime;
        }

        velocity += Vector3.forward * -v*speed;
        velocity += Vector3.left * h*speed;
        velocity += gravity * 10f * Time.deltaTime;

        //TIJDELIJKE CODE HAAL MIJ STRAKS WEG
        velocity += addBoi;


        if (controller.isGrounded)
        {
            velocity.y = Mathf.Min(0, velocity.y);
            jumpForce = Mathf.Min(0, jumpForce);
            if (jumpBuffer > 0f)
            {
                jumpForce = jumpStrength;
            }
        }
        velocity += Vector3.up * jumpForce;
        jumpForce += (gravity.y / 80) * (1 / jumpKill);
        velocity *= 1/weerstand;
        controller.Move(velocity * Time.deltaTime);


    }
}
