using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkThrough : MonoBehaviour

{

    public Transform player;
    public bool walking, stopWalking;
    public CharacterController cc;
    public GameObject walkButton;
    public GameObject stopWalkButton;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (walking)
        {  
            //transform.Translate(Vector3.forward * 3 * Time.deltaTime);
            // player.transform.rotation = Quaternion.Euler(view.x, view.y, view.z);
            float degrees = player.eulerAngles.y;
            Vector3 to = new Vector3(degrees, 0, 0);
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, to, Time.deltaTime);
            transform.Translate(Vector3.Lerp(transform.eulerAngles, to, Time.deltaTime)*1*Time.deltaTime);
            print("walking");
        }
        //ToogleWalk();

    }

    public void Walking()
    {

        walking = true;
        walkButton.SetActive(false);
        stopWalkButton.SetActive(true);
        // Vector3 forward = player.TransformDirection(Vector3.forward);
        //cc.SimpleMove(forward * 4);
    }  

    public void StopWalking()
    {
        walking = false;
        walkButton.SetActive(true);
        stopWalkButton.SetActive(false);
        print("Not walking");

    }


}

