using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveDistance = 7f;
    private bool moveRight = false;
    private Transform enemyTransform;
    private Vector3 startPos;

    void Start() 
    {
        enemyTransform = GetComponent<Transform>();
        startPos = enemyTransform.position;
    }

    void Update()
    {
        if (moveRight)
        {
            enemyTransform.position += Vector3.right * moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(-0.9184f, 0.949f, 1);
            if (enemyTransform.position.x >= startPos.x + moveDistance)
            {
                moveRight = false;
            }
        }
        else
        {
            enemyTransform.position += Vector3.left * moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(0.9184f, 0.949f, 1);
            if (enemyTransform.position.x <= startPos.x - moveDistance)
            {
                moveRight = true;
            }
        }
    }
}


