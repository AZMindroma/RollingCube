using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false;

    public float restartDelay = 1f;

    public float setRotation;

    public Rigidbody rigid;
    public GameObject winning;
    public GameObject disableMusic;

    
    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            disableMusic.SetActive(false);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Winning()
    {
        winning.SetActive(true);
    }

    public void ZeroRotation()
    {
        rigid.rotation = Quaternion.Euler(0, 0, 0);
        rigid.constraints = RigidbodyConstraints.FreezeRotation;
    }
    
}
