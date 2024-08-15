using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public float moveSpeed = 3f;
public float moveDistance = 5f;
private bool moveRight = true;
private Transform enemyTransform;
private Vector3 startPos;

void Start() 
{
    enemytransform = GetComponent<Transform>();
    startPos = enemyTransform.position;
}

void Update()
{
    if (moveRight)
{
    enemyTransform.position += Vector3.right * moveSpeed * Time.deltaTime;
    if  (enemyTransform.position.x>= startPos.x + moveDistance)
    {
        moveRight = false;
    }

}
else
{
    enemyTransform.position +=left
}

}