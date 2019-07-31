using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D myRigidBody2D;
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

            myRigidBody2D.AddForce(transform.up * 500f);

        }
        
    }
}
