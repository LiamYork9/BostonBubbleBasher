using UnityEngine;

public class KickScript : MonoBehaviour
{
    private GameObject player;
    private GameObject boss;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boss = GameObject.FindGameObjectWithTag("Boss");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Kicked");
            player.GetComponent<PlayerScript>().currentHP -= boss.GetComponent<BIGMANStateMachine>().kickDmg;
        }
    }
}
