using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detach2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        D2tach();
    }
    public void D2tach()
    {
        transform.Translate(Vector3.back * 4 * Time.deltaTime);
    }
}
