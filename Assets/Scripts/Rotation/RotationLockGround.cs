using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLockGround : MonoBehaviour
{
    public Rigidbody rigid;
    public float setRotation;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            rigid.rotation = Quaternion.Euler(setRotation, 0, 0);
            rigid.constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (collisionInfo.collider.tag == "Diagonal")
        {
            rigid.rotation = Quaternion.Euler(3, 0, 0);
            rigid.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
