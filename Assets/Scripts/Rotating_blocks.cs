using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_blocks : MonoBehaviour
{
    public GameObject block = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            block.transform.Rotate(0.0f,0.0f,1.0f);
        };

        if(Input.GetKey(KeyCode.LeftArrow)){
            block.transform.Rotate(0.0f,0.0f,-1.0f);
        };

    }
}
