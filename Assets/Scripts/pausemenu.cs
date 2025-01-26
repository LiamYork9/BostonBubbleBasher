using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
     public  bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public UIToggle uiToggle;

    // Update is called once per frame
    void Update()
    {
     if(uiToggle.paused == false){
            if (Input.GetKeyDown(KeyCode.Escape))
            {
             if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
        }   
        }
    }

    public void Resume()
    {
     if(uiToggle.paused == false){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused= false;
     }
    }

    void Pause()
    {
        if(uiToggle.paused == false){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
    }
    public void QuitGame()
    {
        Debug.Log("Sucks at the game");
        Application.Quit();
    }
    public void credits()
    {
        pauseMenuUI.SetActive(true);
    }
    public void exitCredits()
    {
        pauseMenuUI.SetActive(false);
    }
}
