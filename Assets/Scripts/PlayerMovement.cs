using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;

    public float force = 2000f;
    public float sideForce = 500f;

    void FixedUpdate()
    {
        rigid.AddForce(0, 0, force * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigid.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigid.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigid.position.y < -5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
