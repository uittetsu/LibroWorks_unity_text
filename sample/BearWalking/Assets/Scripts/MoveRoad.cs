﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    private Rigidbody roadRigid;
    private Vector3 defPos;

    void Start()
    {
        roadRigid = GetComponent<Rigidbody>();
        defPos = transform.position;

    }
    void FixedUpdate()
    {
        roadRigid.MovePosition(
          new Vector3(defPos.x, defPos.y, defPos.z + Mathf.PingPong(Time.time, 4)));
    }
}