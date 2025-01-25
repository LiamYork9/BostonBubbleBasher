using UnityEngine;

public class Combat : MonoBehaviour
{
    public int i;
    public int spellSpeed;
    public GameObject[] meleeAttacks;
    public GameObject[] magicAttacks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Attack(int attackPrefab, int damage)
    {
        if (meleeAttacks[attackPrefab] != null)
        {
            (Instantiate(meleeAttacks[attackPrefab],transform.position+(new Vector3(1.0f*gameObject.GetComponent<PlayerScript>().facing,0.0f,0.0f)),transform.rotation)).GetComponent<Attack>().damage=damage;
        }
    }
    public void Cast(int spellPrefab, int damage)
    {
        if (magicAttacks[spellPrefab] != null)
        {
            GameObject temp = (Instantiate(magicAttacks[spellPrefab],transform.position+(new Vector3(1.0f*gameObject.GetComponent<PlayerScript>().facing,0.0f,0.0f)),transform.rotation));
            temp.GetComponent<Attack>().damage=damage;
            temp.GetComponent<MoveOverTime>().speed=spellSpeed* gameObject.GetComponent<PlayerScript>().facing;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack(i,gameObject.GetComponent<PlayerScript>().attack);
        }
        else if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Cast(i,gameObject.GetComponent<PlayerScript>().attack);
        }
    }
}
