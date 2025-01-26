using UnityEngine;

public class InstantiateEnemyAttack : MonoBehaviour
{
    public GameObject attack;
    public int facing = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<SpriteRenderer>().flipX==true)
        {
            facing=-1;
        }
        else
        {
            facing=1;
        }
    }

    public void MakeHitbox()
    {
        Instantiate(attack,transform.position+(new Vector3(1.0f*facing,0.0f,0.0f)),transform.rotation);
    }
}
