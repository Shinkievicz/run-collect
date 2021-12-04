using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    float arrowSpeed = 20f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(0, 0, arrowSpeed/15, ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Ground")
        {
            rb.isKinematic = true;
            Destroy(gameObject, 1.002f);
         //   Debug.Log("Do something here");
        }
    }
}
