using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public UnityEvent timeout;
    public float timeLeft;
    public float timeSet;

    void Start()
    {
        timeLeft = timeSet;
    }
    public void StartTime()
    {
        if(timeLeft > 0.0f){
            timeLeft -= Time.deltaTime;

            if(timeLeft <= 0.0f){
                timeout.Invoke();
            }
        }
    }
    public void ResetTime(){
        timeLeft += timeSet;
    }
   
}
