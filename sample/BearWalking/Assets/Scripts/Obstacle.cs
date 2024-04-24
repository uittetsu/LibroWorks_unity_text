using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody obstacleRigid;
    private float lastTime = 0.0f;
    private float timeInterval = 4.0f;
    private float speed = 100f;
    private float direction = -1.0f;

    void Start()
    {
        obstacleRigid = GetComponent<Rigidbody>();
        lastTime = Time.time;
        direction = -1.0f;
    }

    void FixedUpdate()
    {
        if (Time.time >= lastTime + timeInterval)
        {
            lastTime = Time.time;
            direction *= -1.0f;
            obstacleRigid.velocity = Vector3.zero;
        }

        Vector3 bearForward = obstacleRigid.transform.right;
        Vector3 moveVector = speed * (bearForward * direction);
        moveVector.y = 0;
        moveVector.z = 0;
        obstacleRigid.AddForce(moveVector, ForceMode.Impulse);
    }
}