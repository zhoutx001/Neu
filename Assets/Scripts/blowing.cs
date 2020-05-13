using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowing : MonoBehaviour
{

	private float moveSpeed = 0.02f;
    private float currentPos;
    public bool left = false;
    public GameObject micVolume;
    private Vector3 gravity = new Vector3(0, 0.02f, 0);
    
    // Start is called before the first frame update
    void Start()
    {
         currentPos = transform.position.x;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void FixedUpdate()
    {
    /* Move based on Mic volume */
 
    moveSpeed = micVolume.GetComponent<microphone_input>().volume * 0.01f;
    moveSpeed = -moveSpeed;
    // print(moveSpeed);
    // transform.position = new Vector3(0, transform.position.y + moveSpeed, 0);
     
    /* Simulate our own gravity (this one doesn't get stronger when high) */
 
    // transform.position -= gravity;
    }
}
