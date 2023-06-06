using UnityEngine;

public class EndScript : MonoBehaviour
{ 
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.Winning();
    }
}

