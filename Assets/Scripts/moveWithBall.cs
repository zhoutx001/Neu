using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveWithBall : MonoBehaviour
{
    public Transform ballTransform;
    public float MoveCamAhead = 7.6f;
    public GameObject background;
    private SpriteRenderer bg;
    private Vector3 screenBounds;
    private Transform bgTransform;
    // Start is called before the first frame update
    void Start()
    {
        bg = background.GetComponent<SpriteRenderer>();
        bgTransform = background.transform;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log(screenBounds);
        transform.position = new Vector3(ballTransform.position.x+MoveCamAhead, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        // control the background in the view
        if(ballTransform.position.x+MoveCamAhead + screenBounds.x <= bgTransform.position.x+bg.bounds.size.x/2 && ballTransform.position.x+MoveCamAhead - screenBounds.x >= bgTransform.position.x-bg.bounds.size.x/2){
            // Debug.Log(ballTransform.position.x - screenBounds.x);
            transform.position = new Vector3(ballTransform.position.x+MoveCamAhead, 0, -10);   
        }
        
    }
}
