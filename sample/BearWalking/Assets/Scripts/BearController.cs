using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour
{
    private float speed = 3f;
    private float verticalInput = 0f;
    private Rigidbody bearRigidbody;
    private bool isStop = false;

    void Start()
    {
        bearRigidbody = GetComponent<Rigidbody>();
        isStop = false;
    }

    void Update()
    {
        if (isStop)
        {
            return;
        }

        if (transform.position.y < 0.5)
        {
            isStop = true;
            GameObject gameSceneController = GameObject.Find("GameSceneController");
            GameSceneController script =
                gameSceneController.GetComponent<GameSceneController>();
            script.OnFailed();
        }
        else
        {
            verticalInput = Input.GetAxis("Vertical");

            if (Input.GetKey("right"))
            {
                transform.Rotate(0, 10, 0);
            }
            else if (Input.GetKey("left"))
            {
                transform.Rotate(0, -10, 0);
            }
        }
    }

    void FixedUpdate()
    {
        if (isStop)
        {
            return;
        }

        if (bearRigidbody.velocity.sqrMagnitude < 5f)
        {
            Vector3 bearForward = bearRigidbody.transform.forward;
            Vector3 moveVector = speed * (bearForward * verticalInput);
            moveVector.y = 0;
            bearRigidbody.AddForce(moveVector, ForceMode.Impulse);
        }
    }

    public void OnStop()
    {
        isStop = true;
    }
}