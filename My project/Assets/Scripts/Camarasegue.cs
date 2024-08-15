using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;
    public float pX;
    public float pY;
    public float limiteX1;
    public float limiteY1;
    public float limiteX2;
    public float limiteY2;
    public Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            /*if(player.transform.position.x >= limiteX1 && player.transform.position.y <= limiteY1 && player.transform.position.x <= limiteX2 && player.transform.position.y >= limiteY2)
            {
                //transform.position = new Vector3(player.transform.position.x, player.transform.position.y,-3);
                
            }*/
            /*else
            {
                transform.position = new Vector3(pX, pY, -1);
            }*/
            pX = player.transform.position.x;
            pY = player.transform.position.y;
        }
        
        if(pY <= -6)
        {
            transform.position = posInicial;
        }

        if(pX > -6.12 && pY > -1.0)
        {
            transform.position = new Vector3(pX, pY, -1);
        }
        
        
        if(pX < 110 && pY > -14.0)
        {
            transform.position = new Vector3(pX, pY, -1);
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            transform.position = posInicial;
        }
        
    }
}