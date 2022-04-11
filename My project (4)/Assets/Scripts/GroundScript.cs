using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Player"))
        {
            col.collider.GetComponent<Rigidbody>().position = new Vector3(10f, 1f, 0f);
        }
    }
}
