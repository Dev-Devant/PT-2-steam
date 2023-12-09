using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{
    public GameObject obstacle;
    public float init = 5;
    public float frecuency = 1;
     private PlayerController pc;
    void Start()  {
        
        InvokeRepeating("pepeElobstaculizador",init,frecuency);
         GameObject player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
    }
    void Update()  {
        
    }

    void pepeElobstaculizador(){
        if(pc.gameOver){
            return;
        }
        Instantiate(obstacle,transform.position,obstacle.transform.rotation);
    }


}
