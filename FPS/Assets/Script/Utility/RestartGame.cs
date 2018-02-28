using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public float minutesBeforeRestart = 10;
    float timer = 0;

    // Use this for initialization
    void Start()
    {

    }

    void CheckIfIdle()
    {
        if (Input.anyKey)
        {
            timer = 0;

        }
        else
        {
            timer += Time.deltaTime;
            if (timer > minutesBeforeRestart * 60)
            {
                SceneManager.LoadScene("MainMenu");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfIdle();
    }
}
