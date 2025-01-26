using UnityEngine;

public class UIToggle : MonoBehaviour
{

    public GameObject canvas;

    public bool paused = false;

    public pausemenu pauseMenu;

    public void toggleCanvas()
    {
        if(pauseMenu.GameIsPaused == false){
        canvas.SetActive(!canvas.activeInHierarchy);
        }
    }

    public void Resume()
    {
        if(pauseMenu.GameIsPaused == false){
        Time.timeScale = 1f;
        paused= false;
        }
    }

    void Pause()
    {
         if(pauseMenu.GameIsPaused == false){
        Time.timeScale = 0f;
        paused = true;
         }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if(paused) 
            {
                Resume();
            } else {
                Pause();
            }
        toggleCanvas();
        }
    }
}
