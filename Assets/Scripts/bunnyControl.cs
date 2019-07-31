using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnyControl : MonoBehaviour

{
    private Rigidbody2D myRigidBody2D;
    public float bunnyForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {

            myRigidBody2D.AddForce(transform.up * bunnyForce);

        }

    }
}

