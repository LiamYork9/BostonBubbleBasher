using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Combat : MonoBehaviour
{
    public int attackIndex;
    public int spellSpeed;
    public List<GameObject> meleeAttacks;
    public List<GameObject> magicAttacks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Attack()
    {
        Attack(attackIndex);
    }
    public void Attack(int attackPrefab)
    {
        if (meleeAttacks[attackPrefab] != null)
        {
            (Instantiate(meleeAttacks[attackPrefab],transform.position+(new Vector3(1.0f*gameObject.GetComponent<PlayerScript>().facing,0.0f,0.0f)),transform.rotation)).GetComponent<Attack>().damage=gameObject.GetComponent<PlayerScript>().attack;
        }
    }

    public void Cast()
    {
        Cast(attackIndex);
    }
    public void Cast(int spellPrefab)
    {
        if (magicAttacks[spellPrefab] != null)
        {
            GameObject temp = (Instantiate(magicAttacks[spellPrefab],transform.position+(new Vector3(1.0f*gameObject.GetComponent<PlayerScript>().facing,0.0f,0.0f)),transform.rotation));
            temp.GetComponent<Attack>().damage=gameObject.GetComponent<PlayerScript>().attack;
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
            gameObject.GetComponent<Animator>().SetTrigger("Melee");
        }
        else if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Range");
        }
        if(Input.mouseScrollDelta.y>0)
        {
            if(attackIndex+1==meleeAttacks.Count)
            {
                attackIndex = 0;
            }
            else
            {
                attackIndex++;
            }
        }
        else if(Input.mouseScrollDelta.y<0)
        {
            if(attackIndex==0)
            {
                attackIndex=(meleeAttacks.Count)-1;
            }
            else
            {
                attackIndex--;
            }
        }
    }


}
