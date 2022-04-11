using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectKey : MonoBehaviour
{
    public AudioSource collectSound;

    public GameObject scoreText;


    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        scoreText.GetComponent<Text>().text = "Keys: " + ScoringSystem.theScore + "/9";
        Debug.Log("YOU HAVE: " + ScoringSystem.theScore + " KEYS");
        Destroy(gameObject); 
    }
}
