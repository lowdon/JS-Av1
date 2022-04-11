using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject playerFull;

    [SerializeField]
    private Transform respawnPoint;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Transform player = playerFull.GetComponent<Transform>();
        Rigidbody body = playerFull.GetComponent<Rigidbody>();
        player.transform.position = respawnPoint.transform.position;
        body.velocity = Vector3.zero;
    }
}
