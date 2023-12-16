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
    public GameObject particles;
    public AudioClip jumpSFX;
    public AudioClip crashSFX;
    private AudioSource PlayerAS;
    public GameObject image;
    private float pitch;
    void Start()    {
        playerRB = GetComponent<Rigidbody>();       
        Physics.gravity *= gravityMod;
        animController = GetComponent<Animator>(); 
        particles.GetComponent<ParticleSystem>().Play();
        PlayerAS = GetComponent<AudioSource>();
        pitch = PlayerAS.pitch;
    }

    void Update()    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping){
            playerRB.AddForce( Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
            particles.GetComponent<ParticleSystem>().Stop();
            PlayerAS.pitch = pitch + Random.Range(-0.1f,0.1f);
            PlayerAS.PlayOneShot(jumpSFX,1.0f);

            
        }
    }

    void OnCollisionEnter(Collision collision){
        bool saltando = collision.gameObject.CompareTag("Terrain");
        bool obs = collision.gameObject.CompareTag("Obstacle");
        if(saltando){
            jumping = false;
            particles.GetComponent<ParticleSystem>().Play();
            
        }

        if(obs){
            PlayerAS.pitch = pitch + Random.Range(-0.1f,0.1f);
            PlayerAS.PlayOneShot(crashSFX,1.0f);
            gameOver = true;
            animController.SetBool("Death_b",true);
            image.active = true;
        }
    }


}
