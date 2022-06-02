using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool paused = false;

    public GameObject pauseScreen;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(paused == true) {
                Unpause();
                paused = false;
            } else if(paused == false) {
                Pause();
                paused = true;
            }
        }
    }

    public void Pause() {
        pauseScreen.SetActive(true);
        Time.timeScale = 0.5f;
    }

    public void Unpause() {
        pauseScreen.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
