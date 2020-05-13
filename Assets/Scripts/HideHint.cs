using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHint : MonoBehaviour
{
    public GameObject Hint;
    public GameObject HintButton;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Hint.SetActive(false);
        HintButton.SetActive(true);
        Ball.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
