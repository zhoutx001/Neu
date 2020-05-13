using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline_jump : MonoBehaviour
{
   
   public float jumpForce = 22.0f;
    public AudioSource springAudioSource;
    public AudioClip springAudioClip;

    public void playSpringClip()
    {
        springAudioSource.clip = springAudioClip;
        springAudioSource.Play();
    }

    private Animator _animators;
    // Start is called before the first frame update
    void Start()
    {
        _animators = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            _animators.SetTrigger(name: "jump");
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (x:0, y: jumpForce), ForceMode2D.Impulse);
            playSpringClip();
        }
    }
}
