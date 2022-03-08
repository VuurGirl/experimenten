using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class movement : MonoBehaviour
{
    public float speed;
    public Vector3 gravity;

    private CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //float s = Input.GetAxis("")

        Vector3 movement = Vector3.zero;
        movement += Vector3.forward * -v;
        movement += Vector3.left * h;
        movement += gravity;

        movement *= Time.deltaTime;
        controller.Move(movement);


    }
}
