using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{

    public GameObject DeathScreemCanvas;
    // Start is called before the first frame update
    public void ShowDeathScreen()
    {
        DeathScreemCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
