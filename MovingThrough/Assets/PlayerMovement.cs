using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = Vector3.zero;
        rbody.angularVelocity = Vector3.zero;
    }

    void FixedUpdate()
    {
        if(Input.touchCount > 0 || Input.GetMouseButton(0))//move body
        {
            rbody.MovePosition(transform.position+transform.forward*Time.deltaTime*speed);
        }
    }
}