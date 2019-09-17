using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public Camera mycam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);



    }
}
