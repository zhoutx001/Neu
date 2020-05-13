using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        //die
        
    }

    //重置高度
    public void ResetHeight()
    {
        Vector2 v = transform.localPosition;
        v.y+=Random.Range(-500f, 500f);
        transform.localPosition = v;
    }
}
