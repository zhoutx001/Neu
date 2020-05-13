using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadController : MonoBehaviour
{
    public GameObject myBall;
    public float ballPosY;
    public float ballPosX;
    public bool levelMove = false;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        ballPosY = myBall.transform.position.y;
        ballPosX = myBall.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        ballPosY = myBall.transform.position.y;
        ballPosX = myBall.transform.position.x;

        if(!levelMove){
            if (ballPosY < -screenBounds.y || ballPosY > screenBounds.y  || ballPosX < -screenBounds.x || ballPosX > screenBounds.x)
            {
                LevelController.isDead = true;
                StartCoroutine(WaitAndChangeScene(1.0f));
            }
            else
            {
                LevelController.isDead = false;
                print(ballPosY + " " + screenBounds.y);
            }
        }else{
            if(ballPosY < -screenBounds.y || ballPosY > screenBounds.y){
                LevelController.isDead = true;
                StartCoroutine(WaitAndChangeScene(1.0f));
            }else{
                LevelController.isDead = false;
            }

        }
        

        
    }

    IEnumerator WaitAndChangeScene(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(sceneName: "Overview");
    }
}
