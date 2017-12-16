using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public float smoothSpeed = 0.3f;
    public Transform target;
    public float offset_y;
    public float offset_x;



    void LateUpdate () {
        if (target != null)
        {
            setCamera();
        }
        else
        {
            return;
        }
    }

    void setCamera()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
        if ((target.position.y + offset_y) < transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, (target.position.y + offset_y), transform.position.z);
            transform.position = newPos;
        }



        if (target.position.x > transform.position.x - offset_x)
        {
            Vector3 newPos = new Vector3(target.position.x + offset_x, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
        if (target.position.x < transform.position.x - offset_x)
        {
            Vector3 newPos = new Vector3(target.position.x + offset_x, transform.position.y, transform.position.z);
            transform.position = newPos;
        }

    }
}
