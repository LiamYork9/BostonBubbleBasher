using UnityEngine;

public class Soap : MonoBehaviour
{

    //public PlayerScript playerScript;


    public int nonSoapSpeed = GameManager.Instance.moveSpeed;

    public int s;

    public bool soapActive =  false;

    public float soapTime = 0.0f;

    void SpeedBoost()
    {
        //moveSpeed = GameManager.Instance.moveSpeed+5;
        soapTime = 5.0f;
        soapActive = true;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       //playerScript = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        soapTime -=Time.deltaTime;

        if (soapTime <= 0.0f)
        {
            if (soapActive == true)
            {
                //moveSpeed = nonSoapSpeed;
                soapActive = false;
            }
        }
    }

}
