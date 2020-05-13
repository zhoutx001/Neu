using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_block : MonoBehaviour
{
    public GameObject Slide = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            if( Slide.transform.position.x+0.04f < 2.7){
                Slide.transform.position = Slide.transform.position + new Vector3(0.04f,0.04f,0.0f);
            }else{
                // Slide.transform.position =
            }
        };

        if(Input.GetKey(KeyCode.LeftArrow)){
            if(Slide.transform.position.x-0.04f > 0 )
                Slide.transform.position = Slide.transform.position - new Vector3(0.04f,0.04f,0.0f);
        };
    }


}
