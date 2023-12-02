using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour{

    public float Speed = 30;

    void Start()    {       
    }

    void Update()    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
      
    }
}
