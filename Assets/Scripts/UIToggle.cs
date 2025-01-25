using UnityEngine;

public class UIToggle : MonoBehaviour
{

    public GameObject canvas;

    public bool paused = false;

    public void toggleCanvas()
    {
        canvas.SetActive(!canvas.activeInHierarchy);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        paused= false;
    }

    void Pause()
    {
        Time.timeScale = 0f;
        paused = true;
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
