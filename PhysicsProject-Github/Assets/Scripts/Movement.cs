using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Vector2 rotationvector;
    public float angle;
    private float rotation;
    public float modulus;

    public GameObject UIManager;

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (UIManager.GetComponent < UImanager> ().go)
        {
            rb.isKinematic = false;
            calculateVector();
            shoot();
            UIManager.GetComponent<UImanager>().go = false;
        }
        else
        {
            return;
        }
    }

    private void calculateVector()
    {
        rotation = angle * Mathf.Deg2Rad;
        rotationvector = new Vector2(modulus * (Mathf.Cos(rotation)), modulus * (Mathf.Sin(rotation)));
    }

    private void shoot()
    {
        rb.AddForce( rotationvector, ForceMode.Impulse);
    }
}
