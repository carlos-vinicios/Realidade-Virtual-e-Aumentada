using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour
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

    public void SetColorWhite(){
        localMat.color = Color.white;
    }

    public void SetColorBlue(){
        localMat.color = Color.blue;
    }
}
