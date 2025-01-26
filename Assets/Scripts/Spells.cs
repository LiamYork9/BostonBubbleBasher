using UnityEngine;

public class Spells : MonoBehaviour
{


    //Need to have the melee and cast for fireball and poison spells
    public GameObject[] fireballPrefabs;
    public GameObject[] poisonPrefabs;

    public GameObject player;

    public void UnlockFireball()
    {
        player.GetComponent<Combat>().meleeAttacks.Add(fireballPrefabs[0]);
        
        player.GetComponent<Combat>().magicAttacks.Add(fireballPrefabs[1]);
    }

    public void UnlockPoison()
    {
        player.GetComponent<Combat>().meleeAttacks.Add(poisonPrefabs[0]);
        
        player.GetComponent<Combat>().magicAttacks.Add(poisonPrefabs[1]);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
