using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreText;

    private void OnTriggerEnter(Collider other) {
        scoreText.GetComponent<Text>().text = "You have reached The Garden. Peace fulfills your soul.";
        
    }
}
