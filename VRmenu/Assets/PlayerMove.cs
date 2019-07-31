using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rbody;
    public bool walkF = false;

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

    public void ToggleWalk(){
        walkF = !walkF;
    }

    void FixedUpdate(){
        if(walkF)
        {
            rbody.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
        }
    }
}
