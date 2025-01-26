using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DOT : MonoBehaviour
{
    public timer endTimer;
    public float damageTimer = 0;
    public float damageRate = 0.25f;
    public int tickDamage = 1;
    public int duration = 10;
    public Health health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.TryGetComponent<Health>(out health);
        //particle = Instantiate(particle, transform.position, Quaternion.Euler(transform.rotation.x - 90, transform.rotation.y, transform.rotation.z));
        //particle.transform.parent = gameObject.transform;

        if (health == null)
        {
            Destroy(gameObject.GetComponent<DOT>());
            return;
        }

        //messageSpawner = gameObject.GetComponentInChildren<MessageSpawner>();

        endTimer = gameObject.AddComponent<timer>();
        if (endTimer.timeout == null)
            endTimer.timeout = new UnityEvent();

        endTimer.timeSet = duration;
        endTimer.timeout.AddListener(RemoveDOT);
    }

     void FixedUpdate()
    {
        damageTimer += Time.deltaTime;

        if (damageTimer > damageRate)
        {
            health.Hurt(tickDamage);
            damageTimer -= damageRate;
        }
    }

    public void RemoveDOT()
    {
        Destroy(endTimer);
        //Destroy(particle);
        Destroy(gameObject.GetComponent<DOT>());
    }

    public int GetDamage()
    {
        return tickDamage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
