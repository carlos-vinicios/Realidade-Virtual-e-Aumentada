using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitPick : MonoBehaviour
{

    public Transform vrCamera;
    public GameObject fruit;

    public float distance;
    public float smooth;
    
    private bool picked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(vrCamera.position, fruit.transform.position);
        if(dist <= 3.10f && !picked)
            picked = true;

        if(picked){
            Carry();
        }
    }

    public void pick(){
        Carry();
    }

    public void drop(){
        //apagar da tela tambem
        if(picked)
            Destroy(fruit);
    }

    private void Carry(){
        fruit.GetComponent<Rigidbody>().isKinematic = true;
        //fruit.transform.position = fruit.transform.position + new Vector3(vrCamera.transform.forward.x * distance * Time.deltaTime, vrCamera.transform.forward.y * distance * Time.deltaTime, vrCamera.transform.forward.z * distance * Time.deltaTime);
        fruit.transform.position = Vector3.Lerp(fruit.transform.position, vrCamera.transform.position + vrCamera.transform.forward * distance, Time.deltaTime * smooth);
    }
}
