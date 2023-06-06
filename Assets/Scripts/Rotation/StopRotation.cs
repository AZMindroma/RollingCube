using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotation : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject player;
    public GameObject cameraOne;
    public GameObject ramp;

    void OnTriggerEnter()
    {
        ramp.SetActive(false);
        cameraOne.GetComponent<FollowPlayer>().offset.Set(0, 0, -40);
        player.GetComponent<PlayerMovement>().enabled = false;
        gameManager.ZeroRotation();
    }
}
