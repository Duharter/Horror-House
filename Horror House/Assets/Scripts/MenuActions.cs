using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Scenes/Game");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ReturnTitle() {
        SceneManager.LoadScene(0);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void NextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
