using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausepanel;
    public void Play()
    {
        SceneManager.LoadScene("Interaction");
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Ouit()
    {
        Application.Quit();
    }
    public void resume()
    {
        Time.timeScale = 1;
        pausepanel.SetActive(false);
    }
    public void pause()
    {
        Time.timeScale = 0;
        pausepanel.SetActive(true);
    }
}
