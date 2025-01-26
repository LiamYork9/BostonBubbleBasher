using UnityEngine;

public class AreaTrigger : MonoBehaviour
{

    public PlayerScript pScript;
    public GameObject triggerArea;

    public int requierdKills = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //triggerArea.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
       if(pScript.killCount == requierdKills)
       {
            triggerArea.SetActive(true);
       }
        
    }
}
