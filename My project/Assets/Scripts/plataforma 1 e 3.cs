using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma1e3 : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float moveDistance = 5f;
    private bool moveRight = true;
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
            if (enemyTransform.position.x >= startPos.x + moveDistance)
            {
                moveRight = false;
            }
        }
        else
        {
            enemyTransform.position += Vector3.left * moveSpeed * Time.deltaTime;
            if (enemyTransform.position.x <= startPos.x - moveDistance)
            {
                moveRight = true;
            }
        }
    }
}

