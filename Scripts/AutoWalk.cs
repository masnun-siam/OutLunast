using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWalk : MonoBehaviour
{
    public Transform walkingTarget1;
    public GameObject btn;
   

   
    public bool walk1 = false;

    // Start is called before the first frame update
    void Start()
    {
        //float yPos = target.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (walk1)
        {
            float step = 3 * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, walkingTarget1.transform.position, step);
            //print(walkingTarget1.transform.position);
            //print(transform.position);
            if (transform.position == walkingTarget1.transform.position)
            {
                btn.SetActive(false);
                walk1 = false;
            }
        }
        
    }

    private void Walk1()
    {
        walk1 = true;

    }

    public void Walk2Home()
    {
        walk1 = true;
    }

    

}
