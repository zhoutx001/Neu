using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowIntro : MonoBehaviour
{
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        C1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && count == 0)
        {
            C2.SetActive(true);
            count++;
        }
        else if (Input.GetMouseButtonDown(0) && count == 1)
        {
            C3.SetActive(true);
            count++;
        }
        else if (count == 2 && Input.GetMouseButtonDown(0))
        {
            count++;
        }
        else if (count == 3)
        {
            SceneManager.LoadScene("Overview");
        }
    }
}