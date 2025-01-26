using UnityEngine;

public class AreaTrigger : MonoBehaviour
{

    public GameObject guy1;
     public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
       
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        

        if (gameObjects.Length == 0)
        {
           
            guy1.SetActive(true);
        }
    }
}
