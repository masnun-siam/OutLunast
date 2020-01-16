using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Walk : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0)+(3.0f*gameObject.transform.forward), ForceMode.Impulse);

        }
    }
}



