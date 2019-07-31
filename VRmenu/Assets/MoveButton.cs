using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    GameObject mCam;

    // Start is called before the first frame update
    void Start()
    {
        mCam = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float angle_x = this.transform.position.x;
        float angle_y = this.transform.position.y;
        float angle_z = mCam.transform.position.z + 1;
        this.transform.position = new Vector3(angle_x, angle_y, angle_z);
    }
}
