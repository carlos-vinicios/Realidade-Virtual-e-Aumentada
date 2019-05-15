using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
    Material localMat;
    MeshRenderer mRender;

    // Start is called before the first frame update
    void Start()
    {
        mRender = GetComponent<MeshRenderer>();
        localMat = mRender.material;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Gaze Interactions
    public void OnGazeEnter(){
        localMat.color = Color.blue;
    }

    public void OnGazeExit(){
        localMat.color = Color.white;
    }
}
