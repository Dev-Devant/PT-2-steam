using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour{

    public float Speed = 30;
    private PlayerController pc;

    void Start()    {       
        GameObject player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();

    }

    void Update()    {
        if(!pc.gameOver){
            transform.Translate(Vector3.left * Speed * Time.deltaTime);

        }
      
    }
}
