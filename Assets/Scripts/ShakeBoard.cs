using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBoard : MonoBehaviour {

	Rigidbody2D rb;
	float dirX;
	float dirY;
    float dirZ;
    float moveSpeed = 2f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
        dirX = Input.acceleration.x * moveSpeed;
        dirY = Input.acceleration.y * moveSpeed;
        dirZ = Input.acceleration.z * moveSpeed;
        //transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -7.5f, 7.5f), transform.position.y);
        transform.Rotate(0, 0, -dirX);
        //transform.rotation = new Vector3(0, 0, 0);


    }

    //void FixedUpdate()
    //{
    //	rb.velocity = new Vector2 (dirX, 0f);
    //}

}
