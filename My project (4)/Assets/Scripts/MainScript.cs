using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    
    public int bullets = 20;
    public GameObject myTree;

    public GameObject projectile;
    public GameObject cube;
    
    public float fireforce = 1000;
    CharacterController charCtrl;

    public float moveSpeed = 9;
    public float jumpForce = 20;

    private Transform cubeTransform;

    public Vector3 jump;
    public float jumpForceS = 2.0f;

    public bool isGrounded;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        charCtrl = GetComponent<CharacterController>();

        //How to add an object to a node
        Instantiate(myTree, new Vector3(4, 0, -4), Quaternion.identity, GameObject.Find("Trees").transform);

        cubeTransform = cube.transform;

        //enemy = GameObject.Find("Cube").transform;


        /* Comment to unlock the mouse cursor */
        //Cursor.lockState = CursorLockMode.Confined; 
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

    }

    void OnCollisionStay(){
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        float horizontalMouseValue = Input.GetAxis("Mouse X");
        float verticalMouseValue = Input.GetAxis("Mouse Y");

        Rigidbody rb = GetComponent<Rigidbody>();


        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForceS, ForceMode.Impulse);
            isGrounded = false;
        }
    
        transform.position += transform.forward * verticalValue* moveSpeed * Time.deltaTime + transform.right * horizontalValue* moveSpeed * Time.deltaTime;

        //naive version - does not depend on time, doesnt use the correct mouse position
        transform.eulerAngles += new Vector3(-verticalMouseValue , horizontalMouseValue, 0);


    }

    void OnGUI()
    {
        // if (GUI.Button(new Rect(10, 10, 100, 40), "Add bullets"))
        // {
        //     Debug.Log("Add 10 bullets");
        //     bullets += 10+1;  //plus the one that is fired
        // }

        // GUI.contentColor = Color.red;
        // GUI.skin.label.fontSize = 50;
        // GUI.Label(new Rect(10, 50, 400, 100), "bullets " + bullets);
    }

    private bool cubeInFront(){
        Vector3 directionToTarget = transform.position - cubeTransform.position;
        float angle = Vector3.Angle(transform.forward, directionToTarget);
        float distance = directionToTarget.magnitude;
        
        if (Mathf.Abs(angle) < 90 && distance < 1000){
            Debug.Log("target is in front of me");
            return true;
        }
        return false;
    }
}
