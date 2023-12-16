using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour{

    public float Speed = 30;
    public Vector3 initpos ;
    private float repeatWidth;
    private PlayerController pc;
    // Aqui estoy

    void Start()    {       
        initpos = transform.position; 
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
         GameObject player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
    }

    void Update()    {
        if(pc.gameOver){
            return;
        }

        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if (transform.position.x < initpos.x - repeatWidth){
            transform.position = initpos;

        }
    }
}
