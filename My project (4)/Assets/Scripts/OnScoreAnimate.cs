using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScoreAnimate : MonoBehaviour
{
    [SerializeField]
    public Animator doorAnimationController;
    public int desiredScoreTarget;


    private bool objective1;
    private bool objective2;
    private bool objective3;

    void start(){
        objective1 = false;
        objective2 = false;
        objective3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoringSystem.theScore == desiredScoreTarget){
            if(desiredScoreTarget == 2 && objective1 == false){
                objective1 = true;
                doorAnimationController.SetBool("open", true);
                gameObject.GetComponent<AudioSource>().Play();
            }
                
            if(desiredScoreTarget == 5 && objective2 == false){
                objective2 = true;
                doorAnimationController.SetBool("open2", true);
                gameObject.GetComponent<AudioSource>().Play();
            }

            if(desiredScoreTarget == 9 && objective3 == false){
                objective2 = true;
                doorAnimationController.SetBool("open3", true);
                gameObject.GetComponent<AudioSource>().Play();
            }
            
        }
    }


}
