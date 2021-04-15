using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;


    public Transform groundcheck;
    public float grounddistance = 0.04f;
    public LayerMask groundMask;
    public float jumpheight = 3f;

    bool isGrounded;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        //if(Input.GetButtonDown("jump")&& isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity);
        //}

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move *speed *Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
