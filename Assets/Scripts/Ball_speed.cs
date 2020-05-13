using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_speed : MonoBehaviour
{
    public GameObject Ball = null;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D ballRigid = Ball.GetComponent<Rigidbody2D>();
        ballRigid.AddForce(new Vector2(x:0, y:3.0f),ForceMode2D.Impulse);  
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


 
}
