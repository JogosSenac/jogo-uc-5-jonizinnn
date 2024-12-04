using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator animPlayer;
    private SpriteRenderer sprite;
    private Rigidbody2D rigBody;
    public int speed = 5;
    private bool isJumping;
    public int key;

    // Start is called before the first frame update
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rigBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movH = Input.GetAxis("Horizontal");
        float movV = Input.GetAxis("Vertical");

        transform.position += new Vector3(movH * Time.deltaTime * speed, movV * Time.deltaTime * speed,0);



        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            sprite.flipX = false;
            animPlayer.SetLayerWeight(2, 1);
            rigBody.AddForce(new Vector2(1.0f, speed), ForceMode2D.Impulse);
            isJumping = true;
        }
        else
        {
            animPlayer.SetLayerWeight(2, 0);
        }
        

        if(Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
            animPlayer.SetLayerWeight(1, 1);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
            animPlayer.SetLayerWeight(1, 1);
        }
        else
        {
            animPlayer.SetLayerWeight(1, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "Porta1")
        {
            transform.position = new Vector3(15.0f,-3.0f,0);
        }

        if(other.gameObject.name == "Porta2")
        {
            transform.position = new Vector3(10.0f,1.0f,0);
        }
        if(other.gameObject.CompareTag("chave"))
        {
            Destroy(other.gameObject);
            key+=1;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Morte"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Morte");
        }

        
        if (other.gameObject.CompareTag("Porta")&& key==3)
        {
           Destroy(this.gameObject);
           SceneManager.LoadScene("Vitoria");
        }
        
    }

}
