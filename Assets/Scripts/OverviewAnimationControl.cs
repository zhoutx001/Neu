using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewAnimationControl : MonoBehaviour
{
    public Button leftBtn;
    public Button rightBtn;

    public GameObject Hippocampus;
    public GameObject Amygdala;
    public GameObject TPJ;

    private Animator _animator_amygd;
    private Animator _animator_hippo;
    private Animator _animator_tpj;

    private int whichAnimation;

    void Start()
    {
        Button btnL = leftBtn.GetComponent<Button>();
        btnL.onClick.AddListener(Left);

        Button btnR = rightBtn.GetComponent<Button>();
        btnR.onClick.AddListener(Right);

        _animator_amygd = Amygdala.GetComponent<Animator>();
        _animator_hippo = Hippocampus.GetComponent<Animator>();
        _animator_tpj = TPJ.GetComponent<Animator>();

        whichAnimation = LevelController.currentLevel;
        PlayAnimationRight(whichAnimation);
    }

    private void Update()
    {
        
    }


    void Left()
    {
        
        if (whichAnimation > 0 && whichAnimation <= LevelController.LEVELNUM){
            whichAnimation--;
            LevelController.currentLevel --;
            Debug.Log(whichAnimation);
            PlayAnimationLeft(whichAnimation);
        }
            
    }

    void Right()
    {
        if (whichAnimation < LevelController.LEVELNUM && whichAnimation >= 0){
            whichAnimation++;
            LevelController.currentLevel ++;
            Debug.Log(whichAnimation);
            PlayAnimationRight(whichAnimation);
        }
            
    }


    void PlayAnimationRight(int whichAnimation) {
        switch (whichAnimation){
            case 1:
                Amygdala.SetActive(true); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(false); // enable current animation
                _animator_amygd.SetTrigger(name: "ShowRight"); // set trigger to activate animation
                break;
            case 2:
                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(true); // enable current animation
                // _animator_hippo.SetTrigger(name: "ShowHippocampus"); // set trigger to activate animation
                _animator_hippo.SetTrigger(name: "ShowRight");
                break;
            case 3:
                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(true);
                Hippocampus.SetActive(false); // enable current animation
                // _animator_tpj.SetTrigger(name: "ShowTPJ"); // set trigger to activate animation
                _animator_tpj.SetTrigger(name: "ShowRight");
                break;
            default:
                // Amygdala.SetActive(true); // last level animation disable
                // TPJ.SetActive(false);
                // Hippocampus.SetActive(false); // enable current animation
                // _animator_amygd.SetTrigger(name: "ShowRight"); // set trigger to activate animation
                break;
        }
      
    }

    void PlayAnimationLeft(int whichAnimation) {
        switch (whichAnimation){
            case 0:
                Amygdala.SetActive(true); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(false); // enable current animation
                _animator_amygd.SetTrigger(name: "ShowLeft"); // set trigger to activate animation
                break;
            case 1:
                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(true); // enable current animation
                _animator_hippo.SetTrigger(name: "ShowLeft"); // set trigger to activate animation
                break;
            case 2:
                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(true);
                Hippocampus.SetActive(false); // enable current animation
                _animator_tpj.SetTrigger(name: "ShowLeft"); // set trigger to activate animation
                break;
            default:
                // Amygdala.SetActive(true); // last level animation disable
                // TPJ.SetActive(false);
                // Hippocampus.SetActive(false); // enable current animation
                // _animator_amygd.SetTrigger(name: "ShowLeft"); // set trigger to activate animation
                break;
        }
      
    }


}

