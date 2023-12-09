using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;
    private bool jumping = false;
    public bool gameOver = false;
    private Animator animController;

    void Start()    {
        playerRB = GetComponent<Rigidbody>();       
        Physics.gravity *= gravityMod;
        animController = GetComponent<Animator>(); 
    }

    void Update()    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping){
            playerRB.AddForce( Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
            animController.SetTrigger("Jump_trig");
        }
    }

    void OnCollisionEnter(Collision collision){
        bool saltando = collision.gameObject.CompareTag("Terrain");
        bool obs = collision.gameObject.CompareTag("Obstacle");
        if(saltando){
            jumping = false;
        }

        if(obs){
            Debug.Log("Choco con una caja");
            gameOver = true;
        }
    }


}
