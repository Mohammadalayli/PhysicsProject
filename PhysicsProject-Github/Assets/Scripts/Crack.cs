using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack : MonoBehaviour {

    public GameObject cracked;
    private Vector3 up = new Vector3(90,0,0);

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(cracked, transform.position, transform.rotation * Quaternion.Euler(up));
    }
}
