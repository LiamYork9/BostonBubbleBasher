using UnityEngine;

public class Spells : MonoBehaviour
{


    //Need to have the melee and cast for fireball and poison spells
    public GameObject[] fireballPrefabs;
    public GameObject[] poisonPrefabs;

    public GameObject player;

    public void UnlockFireball()
    {
        GameManager.Instance.UnlockAttacks(fireballPrefabs[0],fireballPrefabs[1]);
    }

    public void UnlockPoison()
    {
        GameManager.Instance.UnlockAttacks(poisonPrefabs[0],poisonPrefabs[1]);
    }

    public void UnlockReactiveShield()
    {
        GameManager.Instance.UnlockShield();
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
