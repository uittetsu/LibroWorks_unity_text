using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour
{
    private float speed = 3f;
    private float verticalInput = 0f;
    private Rigidbody bearRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bearRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
