using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    //public Transform nave;
    public float speed = 20f;
    public float spd_rotation = 6f;

    float distanceTravelled = 0;
    Vector3 lastPosition;

    private bool left = false;
    private bool right = false;
    private bool norma_l = false;
    private bool norma_r = false;

    private int cont_l = 0;
    private int cont_r = 0;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //print(distanceTravelled);

        if(distanceTravelled >= 60 && distanceTravelled < 61)
            right = true;
        if(distanceTravelled >= 200 && distanceTravelled < 210)
            left = true;

        fly_straight();
        fly_left();
        fly_right();
        normalize();
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
    }

    private void fly_straight(){
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void fly_left(){
        if(left){
            print(transform.rotation.eulerAngles.z);
            if(cont_l < 220){
                norma_l = false;
                transform.Rotate(speed * Time.deltaTime * (-1), speed * Time.deltaTime * (-1), speed * Time.deltaTime);
                cont_l++;
            }else{
                norma_l = true;
                cont_l = 0;
            }
        }
    }

    private void fly_right(){
        if(right){
            print(transform.rotation.eulerAngles.y);
            if(cont_r < 220){
                norma_r = false;
                transform.Rotate(speed * Time.deltaTime * (-1), speed * Time.deltaTime, speed * Time.deltaTime * (-1));
                cont_r++;
            }else{
                norma_r = true;
                cont_r = 0;
            }
        }
    }

    private void normalize(){
        int relu = 0;
        
        if(norma_l || norma_r){
            if(left){
                left = false;     
            }else if(right){
                right = false;
            }
            if(norma_l)
                relu = -1;
                if(transform.rotation.eulerAngles.z >= 1)
                    transform.Rotate(0, 0, speed * Time.deltaTime * relu);
            if(norma_r)
                relu = 1;
                if(transform.rotation.eulerAngles.z >= 1)
                    transform.Rotate(0, 0, speed * Time.deltaTime * relu);
        }
    }

}
