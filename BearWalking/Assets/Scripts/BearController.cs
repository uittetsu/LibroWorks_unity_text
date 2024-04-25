using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour
{
    private float speed = 3f;
    private float verticalInput = 0f;
    private Rigidbody bearRigidbody;
    private bool isStop;

    // Start is called before the first frame update
    void Start()
    {
        bearRigidbody = GetComponent<Rigidbody>();
        isStop = false;
    }

    // Update is called once per frame
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
            GameSceneController script = gameSceneController.GetComponent<GameSceneController>();
            script.OnFailed();
        }

        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey("right"))
        {
            bearRigidbody.transform.Rotate(0, 0.1f, 0);
        }
        else if (Input.GetKey("left"))
        {
            bearRigidbody.transform.Rotate(0, -0.1f, 0);
        }
    }

    void FixedUpdate()
    {
        if (bearRigidbody.velocity.sqrMagnitude < 5f)
        {
            Vector3 bearForward = bearRigidbody.transform.forward;
            Vector3 moveVector = speed * (bearForward * verticalInput);
            moveVector.y = 0;
            bearRigidbody.AddForce(moveVector, ForceMode.Impulse);
        }
    }
}
