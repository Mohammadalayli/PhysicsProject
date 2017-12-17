using UnityEngine;

public class FractureDestroy : MonoBehaviour {

    public GameObject cracked;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Instantiate(cracked, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(cracked, transform.position, transform.rotation);
        Debug.Log("Victory");
    }
}