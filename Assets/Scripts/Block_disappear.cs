using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_disappear : MonoBehaviour
{
    public GameObject block = null;
    SpriteRenderer m_SpriteRenderer;
    int collisionNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        collisionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            collisionNumber ++;
           m_SpriteRenderer.color = new Color(1f,1f,1f,1f - 0.2f*collisionNumber);
        }
         if(collisionNumber >= 5){
            block.SetActive(false);
        }
    }
}
