using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //向上的力
    public float Force = 3;

    //刚体
    private Rigidbody2D rbody;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
       //点击鼠标

      if (Input.GetMouseButtonDown(0))
        {
          
           rbody.velocity = new Vector2(0, Force);
        }
    }
}
