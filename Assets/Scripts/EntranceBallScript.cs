using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceBallScript : MonoBehaviour
{
    public GameObject Ball = null;
    public bool IsVisible = true;
    private Animator _animator;
    private Renderer _renderer;

    public AudioSource entryAudioSource;
    public AudioClip entryAudioClip;

    public void playEntryClip()
    {
        entryAudioSource.clip = entryAudioClip;
        entryAudioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetTrigger(name:"BallDrop");

        StartCoroutine(WaitAndPlay(0.5F));
        if (!IsVisible){
            StartCoroutine(WaitAndPrint(1.8F));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

      IEnumerator WaitAndPrint(float waitTime)  
    {  

        yield return new WaitForSeconds(waitTime);
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = false;
        
    }


    IEnumerator WaitAndPlay(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        playEntryClip();

    }
}
