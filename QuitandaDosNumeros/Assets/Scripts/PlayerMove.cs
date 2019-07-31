using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform vrCamera;

    public float toggleAngle = 30.0f;

    public float speed = 7.0f;

    public bool moveForward;

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

        if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f){ //se abaixar em um certo intervalo, ativa a movimentação
            moveForward = true;
        }else{
            moveForward = false;
        }

        if(moveForward){
            //transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * speed; //esse daqui quando a gente for botar para voar
            transform.position = transform.position + new Vector3(vrCamera.transform.forward.x * speed * Time.deltaTime, 0, vrCamera.transform.forward.z * speed * Time.deltaTime); // add 0 to keep the y coordinate the same
            rbody.MovePosition(transform.position);
        }
    }
}
