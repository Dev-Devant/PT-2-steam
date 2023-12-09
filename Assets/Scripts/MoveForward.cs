using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour{

    public float Speed = 30;
    private PlayerController pc;
    public GameObject VFX;

    void Start()    {       
        GameObject player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();

    }

    void Update()    {
        if(pc.gameOver){
            return;
        }
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
        if(!collision.gameObject.CompareTag("Player")){
            return;
        }

        Instantiate(VFX,transform.position,VFX.transform.rotation);
        Destroy(gameObject);
    
    }
}
