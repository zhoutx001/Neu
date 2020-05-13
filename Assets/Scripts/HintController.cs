using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintController : MonoBehaviour
{
    public GameObject textcontent;
    private string scienceFact;
    private int whichArea;

    // Start is called before the first frame update
    void Start()
    {    
        whichArea = 1;//过关变量（activate sciFact,不同scifact）
    }

    // Update is called once per frame
    void Update()
    {
        whichArea = LevelController.currentLevel;
        Debug.Log(whichArea);
        SciFact(whichArea);
        textcontent.GetComponent<Text>().text = scienceFact;
    }

    void SciFact(int whichArea) {

        switch (whichArea)
        {
            case 1:
                scienceFact = "Boost your reaction by bouncing against fear of danger.";
                break;
            case 2:
                scienceFact = "Use the gyroscope to go through the complex spatial maze.";
                break;
            case 3:
                scienceFact = "Use the blower to hit the blocks till it breaks down.";
                break;
            default: 
                scienceFact = "Choices in familiar places would earn my vote";
                break;
        }

    }
}
