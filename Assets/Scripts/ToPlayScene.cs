﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlayScene : MonoBehaviour
{
    //public string scenename;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Play_01");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


}
