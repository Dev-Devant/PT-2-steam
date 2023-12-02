using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;
    private bool jumping = false;

    void Start()    {
        playerRB = GetComponent<Rigidbody>();       
        Physics.gravity *= gravityMod; 
    }

    void Update()    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping){
            playerRB.AddForce( Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
        }
    }

    void OnCollisionEnter(Collision collision){
        jumping = false;
    }


}
