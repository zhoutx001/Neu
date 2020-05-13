using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScienceFactContent : MonoBehaviour
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
                scienceFact = "Amygdala" + "\n\n" + "Get the help from amygdala who can distinguish "+ "\n" +"fear quickly to avoid dangers.";
                break;
            case 2:
                scienceFact = "Hippocampus"+"\n\n"+"Choices in familiar places would earn my vote.";
                break;
            case 3:
                scienceFact = "Temporoparital Junction" + "\n\n" + "To keep you as a social person, you need assistance " + "\n" + "from here, which would quantify the social values " + "\n" + "in choices.";
                break;
            default: 
                scienceFact = "Amygdala" + "\n" + "Choices in familiar places would earn my vote";
                break;
        }

    }
}
