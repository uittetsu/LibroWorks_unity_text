using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    private Rigidbody roadRigid;
    private Vector3 defPos;

    // Start is called before the first frame update
    void Start()
    {
        roadRigid = GetComponent<Rigidbody>();
        defPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        roadRigid.MovePosition(new Vector3(defPos.x, defPos.y, defPos.z + Mathf.PingPong(Time.time, 4)));
    }
}
