using UnityEngine;

public class KickScript : MonoBehaviour
{
    private GameObject player;
    public GameObject boss;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Kicked");
            if(player.GetComponent<PlayerScript>().currentHP!=null)
            {
            player.GetComponent<PlayerScript>().currentHP -= boss.GetComponent<BIGMANStateMachine>().kickDmg;
            }
        }
    }
}
