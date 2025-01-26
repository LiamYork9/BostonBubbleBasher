using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject player;
    private GameObject boss;
    public float dmgTickRate = .5f;
    public float nextTick = -1.0f;
    public bool canDmg = true;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boss = GameObject.FindGameObjectWithTag("Boss");
        nextTick = Time.time + dmgTickRate;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Time.time > nextTick)
            {
                canDmg = true;
            }
            if (canDmg)
            {
                player.GetComponent<PlayerScript>().currentHP -= boss.GetComponent<BIGMANStateMachine>().bulletDmg;
                nextTick = Time.time + dmgTickRate;
                canDmg = false;
            }
        }
    }
}
