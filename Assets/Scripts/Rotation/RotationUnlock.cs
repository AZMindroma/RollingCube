﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationUnlock : MonoBehaviour
{
    public float setRotation;
    public Rigidbody rigid;

    private void OnTriggerEnter(Collider other)
    {
        rigid.rotation = Quaternion.Euler(setRotation, 0, 0);
        rigid.constraints &= ~RigidbodyConstraints.FreezeRotationX;
    }
}
