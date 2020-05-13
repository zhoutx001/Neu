using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    public GameObject FactPage = null;
    public GameObject Ball = null;
    public GameObject Entrance = null;
    private Rigidbody2D ballRigid;
    private bool Next = false;
    private Animator _animator_next = null;
    // Start is called before the first frame update
    void Start()
    {
        _animator_next = Entrance.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Next && Input.GetMouseButtonDown(0)){
            
            // FactPage.SetActive(false);
            SceneManager.LoadScene("Play_2");

        }   
            
    }
}
