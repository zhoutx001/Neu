using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour
{
    //背景移动速度

    public float speed = 0.2f;
    ////背景宽度
    public float width = 2.85f;
    //是否重置pipe
    public bool resetPipeHeight = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        foreach (Transform trans in transform)


        {
            //移动背景
            Vector3 v = transform.position;
            v.x -= speed * Time.deltaTime;

            //切换新位置
            if (v.x < -width)
            {
                v.x += width ;
                //重置高度
                if(resetPipeHeight)
                {
                    Pipecontrol pipe = trans.GetComponentInChildren<Pipecontrol>();
                    pipe.ResetHeight();
                }
            }
            transform.position = v;
        }
    }
}

