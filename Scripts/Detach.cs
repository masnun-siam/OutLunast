using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dtach();
    }
    public void Dtach()
    {
        transform.Translate(Vector3.back * 2 * Time.deltaTime);
    }
}
