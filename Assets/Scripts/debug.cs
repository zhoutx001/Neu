using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    float dirY;
    float dirZ;
    float moveSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        dirY = Input.acceleration.y * moveSpeed;
        dirZ = Input.acceleration.z * moveSpeed;
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);

        //gameObject.transform.rotation = new Quaternion(0, 0, -50, 0);
        if (transform.rotation.z > -50)
        {
            transform.Rotate(0, 0, -dirX);
            //Debug.Log("win");
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, -50, 0);
            //Debug.Log("win");
        }

       // Debug.Log("win");
    }
}
