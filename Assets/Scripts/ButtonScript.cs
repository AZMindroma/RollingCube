using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelSelection;
    public GameObject button;
    public GameObject button2;

    public void OnButtonTouch()
    {
        if (button.name == "B_Start")
        {
            startMenu.SetActive(false);
            levelSelection.SetActive(true);
        }
        if (button.name == "B_StartTutorial")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (button.name == "B_Quit")
        {
            Application.Quit();
        }
    }

    public void OnButton2Touch()
    {
        if (button2.name == "B_StartIdols")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
