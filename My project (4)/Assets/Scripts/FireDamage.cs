using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnParticleCollision(GameObject other) {
        //other.transform = RespawnSystem.current;
        Transform playerPos = other.GetComponent<Transform>();
        playerPos = spawnPoint;
        Debug.Log("smells fire?");
    }
}
