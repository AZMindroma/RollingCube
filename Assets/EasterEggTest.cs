using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEggTest : MonoBehaviour
{
    private string[] cheatCode;
    private int index;

    void Start()
    {
        cheatCode = new string[] { "s", "a", "r", "s", "v", "i", "d", "1", "9"};
        index = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(cheatCode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == cheatCode.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
