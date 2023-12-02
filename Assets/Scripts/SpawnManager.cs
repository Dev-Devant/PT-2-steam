using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{
    public GameObject obstacle;
    public float init = 5;
    public float frecuency = 1;
    void Start()  {
        
        InvokeRepeating("pepeElobstaculizador",init,frecuency);
    }
    void Update()  {
        
    }

    void pepeElobstaculizador(){
        Instantiate(obstacle,transform.position,obstacle.transform.rotation);
    }


}
