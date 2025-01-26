using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastDoor : MonoBehaviour
{
    public GameObject killIt;

    public string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    { 
         if (collision.gameObject.CompareTag("Player"))
         {
            Destroy(killIt);
            LoadScene();
         }

    }

      public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
