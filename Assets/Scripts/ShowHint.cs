using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHint : MonoBehaviour
{
    public GameObject Hint;
    public GameObject HintButton;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Hint.SetActive(true);
        HintButton.SetActive(false);
        Ball.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
