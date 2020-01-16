using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth3scene : MonoBehaviour
{

    public LevelChanger changeLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("N", 25);
    }

    public void N()
    {
        changeLevel.FadeToNextLevel();

    }
}
