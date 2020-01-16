using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Lift", 1.5f);
    }

    public void Lift()
    {
        transform.Translate(Vector3.back * 7.5f * Time.deltaTime);
    }
}
