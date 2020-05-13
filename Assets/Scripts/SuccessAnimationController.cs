using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessAnimationController : MonoBehaviour
{
    public GameObject Hippocampus;
    public GameObject Amygdala;
    public GameObject TPJ;

    private Animator _animator_amygd;
    private Animator _animator_hippo;
    private Animator _animator_tpj;

    private int whichAnimation;
    // Start is called before the first frame update
    void Start()
    {
        _animator_amygd = Amygdala.GetComponent<Animator>();
        _animator_hippo = Hippocampus.GetComponent<Animator>();
        _animator_tpj = TPJ.GetComponent<Animator>();

        whichAnimation = LevelController.currentLevel;
    }

    private void Update()
    {
        PlayAnimation();
    }

    void PlayAnimation()
    {
        //whichAnimation here indicates upcoming level
        switch (whichAnimation)
        {
            case 1:
                Amygdala.SetActive(true); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(false); // enable current animation
                // _animator_amygd.SetTrigger(name: "ShowAmygdala"); // set trigger to activate animation
                break;
            case 2:

                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(true); // enable current animation
                // _animator_hippo.SetTrigger(name: "ShowHippocampus"); // set trigger to activate animation
                break;
            case 3:
                Amygdala.SetActive(false); // last level animation disable
                TPJ.SetActive(true);
                Hippocampus.SetActive(false); // enable current animation
                // _animator_tpj.SetTrigger(name: "ShowTPJ"); // set trigger to activate animation
                break;
            default:
                Amygdala.SetActive(true); // last level animation disable
                TPJ.SetActive(false);
                Hippocampus.SetActive(false); // enable current animation
                // _animator_amygd.SetTrigger(name: "ShowAmygdala"); // set trigger to activate animation
                break;
        }
    }
}