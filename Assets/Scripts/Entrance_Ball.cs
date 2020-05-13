using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance_Ball : MonoBehaviour
{
    public GameObject Ball = null;
    public bool IsGravity = true;
    // private bool ClickSpeed = false;
    private float FirstImpulse = 0.2f;
    public bool ClickActive;
    
    // Start is called before the first frame update
    void Start()
    {
        // set time to wait for animation finishes.
        Ball.GetComponent<Renderer>().enabled = false;
        Ball.GetComponent<Rigidbody2D>().gravityScale = 0;
        StartCoroutine(WaitAndPrint(1.02F));
       
    }

    // Update is called once per frame
    void Update()
    {
        // Add impulse to roll the first time when user clicks the mouse
         if(ClickActive && Input.GetMouseButtonDown(0)){
            Rigidbody2D ballRigid = Ball.GetComponent<Rigidbody2D>();
            ballRigid.AddForce(new Vector2(x:FirstImpulse, y:0.0f),ForceMode2D.Impulse);  
            // ClickSpeed = true;
        }
            
    }
    
    
    IEnumerator WaitAndPrint(float waitTime)  
    {  
        yield return new WaitForSeconds(waitTime);
        Ball.GetComponent<Renderer>().enabled = true;
        if(IsGravity){
            Ball.GetComponent<Rigidbody2D>().gravityScale= 1;
        }
        
        // ClickActive = true;
           
    } 


}
