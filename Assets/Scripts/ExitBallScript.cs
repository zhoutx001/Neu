using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitBallScript : MonoBehaviour
{
    public GameObject Ball = null;
    private Animator _animator;
    public bool levelSuccess = false;
    public bool pass = false;
    public GameObject ScienceFact = null;
    public AudioSource exitAudioSource;
    public AudioClip exitAudioClip;

    public void playExitClip()
    {
        exitAudioSource.clip = exitAudioClip;
        exitAudioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
           _animator.SetTrigger(name:"BallHit");
           Debug.Log("HIt");
           playExitClip();
           levelSuccess = true;
        }

        if(!pass && levelSuccess){
            Ball.SetActive(false);
            StartCoroutine(WaitAndChangeScene(1.0f));
            pass = true;
            
        }
    }

     IEnumerator WaitAndChangeScene(float waitTime)  
    {  
        yield return new WaitForSeconds(waitTime);
        // ScienceFact.SetActive(true);
        if (LevelController.currentLevel < LevelController.LEVELNUM) {
            LevelController.currentLevel++;
        }
        
        SceneManager.LoadScene(sceneName:"LevelSuccess");
           
    } 
}
