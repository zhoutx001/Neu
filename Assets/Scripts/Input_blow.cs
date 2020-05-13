using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Input_blow : MonoBehaviour
{

    public float speed = 1.5f;
    private float totalDownTime = 0.0f;
    private bool clicking = false;
    public GameObject fan = null;
    // public GameObject fan2 = null;
    public GameObject ball = null;
    private Rigidbody2D ballRigid;

    void Awake(){
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject fan = GameObject.Find("inner_blower");
        ballRigid = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if hitting the collider
        if(Input.GetMouseButtonDown(0)){
            
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll = fan.GetComponent<Collider2D>();
            

            if(coll.OverlapPoint(wp)){
                clicking = true;
                Debug.Log ("Hit by mouse!");
                totalDownTime = 0.0f;
            }
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // RaycastHit hit;

            // if (Physics.Raycast (ray, out hit)) {
            //     Debug.Log ("Hit by mouse!");
            //     totalDownTime = 0.0f;
            //     clicking = true;
            // }    
            
        }

        if(clicking && Input.GetMouseButton(0)){
            // Debug.Log(totalDownTime);
            if(totalDownTime <= 2.0f){
                totalDownTime += Time.deltaTime;
                fan.transform.Rotate(0.0f,0.0f,3*totalDownTime);
            }else{
                fan.transform.Rotate(0.0f,0.0f,6.0f);
                totalDownTime = 6.0f;
            }
        }

        if(clicking && Input.GetMouseButtonUp(0)){
            clicking = false;
        }

        if(!clicking && totalDownTime >= 0){ 
            totalDownTime -= Time.deltaTime;
            fan.transform.Rotate(0.0f,0.0f,3*totalDownTime);
        }

        

        if(totalDownTime > 0.0f){
            Debug.Log(fan.transform.position.x);
            if(ball.transform.position.y <= 1 && ball.transform.position.y >= -1){
                ballRigid.AddForce(transform.right*totalDownTime*10.0f,ForceMode2D.Force);
                Debug.Log("Add");
                // ballRigid.transform.position += Vector3.up * totalDownTime*0.003f; // change attribu 
            } 
        } 
            
    }
    
    // void onMouseDown(){
    //     if(ball.transform.position.x >= fan.transform.position.x-0.5 && ball.transform.position.x <= fan.transform.position.x+0.5){
    //          ballRigid.AddForce(transform.right*totalDownTime*50.0f,ForceMode2D.Force);
    //          Debug.Log("Add");
    //         // ballRigid.transform.position += Vector3.up * totalDownTime*0.003f; // change attribu 
    //     }  
    // }
}
