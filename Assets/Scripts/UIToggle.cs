using UnityEngine;

public class UIToggle : MonoBehaviour
{

    public GameObject canvas;

    public bool paused = false;

    public void toggleCanvas()
    {
        canvas.SetActive(!canvas.activeInHierarchy);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if(paused == false) 
            {
                paused = true;
                Time.timeScale = 0.0f;
            } else {
                paused = false;
                Time.timeScale = 1.0f;
            }
        toggleCanvas();
        }
    }
}
