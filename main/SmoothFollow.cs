using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public GameObject target;
    
    // stickiness of the camera
    public float followSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //change in position for the camera
        Vector3 movePos = Vector3.Lerp(this.transform.position, target.transform.position, followSpeed);

        
        this.transform. position = movePos;
    }
}
