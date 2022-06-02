using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public PauseMenu pauseMenuLogic;

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu Scene");
    }

    public void UnPause() {
        pauseMenuLogic.Unpause();
    }
}
