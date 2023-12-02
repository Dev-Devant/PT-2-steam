using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour{

    public float Speed = 30;
    public Vector3 initpos ;
    private float repeatWidth;

    void Start()    {       
        initpos = transform.position; 
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
    }

    void Update()    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if (transform.position.x < initpos.x - repeatWidth){
            transform.position = initpos;

        }
    }
}
