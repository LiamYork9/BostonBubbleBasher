using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> meleeHitboxes;
    public List<GameObject> rangeHitboxes; 

    public Text lvText;

    public Text spText;

    public Text healthText;

    public GameObject bubbleShield;
    public bool shieldUnlocked;

    //player values
    public int lv = 1;
    public int maxhp = 10;
    public int moveSpeed = 5;
    public int attack = 5;
    public int defense = 1;
    public int skillPoint = 0;

    public void UnlockShield()
    {
        shieldUnlocked = true;
        player.GetComponent<PlayerScript>().shieldUnlocked = shieldUnlocked;
    }

    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        gameObject.GetComponentInChildren<UIToggle>().pauseMenu = player.GetComponentInChildren<pausemenu>();
        player.GetComponentInChildren<pausemenu>().uiToggle = gameObject.GetComponentInChildren<UIToggle>();
        player.GetComponent<Combat>().meleeAttacks = meleeHitboxes;
        player.GetComponent<Combat>().magicAttacks = rangeHitboxes;
        PlayerScript temp =player.GetComponent<PlayerScript>();
        temp.lvText = lvText;
        temp.spText = spText;
        temp.healthText = healthText;
        temp.shieldUnlocked = shieldUnlocked;
        temp.lv = lv;
        temp.hp = maxhp;
        temp.skillPoint=skillPoint;
        temp.moveSpeed = moveSpeed;
        temp.attack = attack;
        temp.defense = defense;
    }

    public void Update()
    {
      
    }

    public void UnlockAttacks(GameObject melee, GameObject range)
    {
        meleeHitboxes.Add(melee);
        rangeHitboxes.Add(range);

        player.GetComponent<Combat>().meleeAttacks = meleeHitboxes;
        player.GetComponent<Combat>().magicAttacks = rangeHitboxes;
    }
    public static GameManager Instance { get; private set; } = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //Stat Updates
    public void UpdateMaxHP(int newValue)
    {
        maxhp = newValue;
        player.GetComponent<PlayerScript>().hp=maxhp;
        
        player.GetComponent<PlayerScript>().currentHP=maxhp;
    }

    public void UpdateLVL(int newValue)
    {
        lv= newValue;
        player.GetComponent<PlayerScript>().lv=lv;
    }

    public void UpdateSpeed(int newValue)
    {
        moveSpeed= newValue;
        player.GetComponent<PlayerScript>().moveSpeed=moveSpeed;
    }

    public void UpdateAttack(int newValue)
    {
        attack= newValue;
        player.GetComponent<PlayerScript>().attack=attack;
    }

    public void UpdateSkillPoint(int newValue)
    {
       skillPoint= newValue;
        player.GetComponent<PlayerScript>().skillPoint=skillPoint;
    }

    public void UpdateDefense(int newValue)
    {
       defense= newValue;
        player.GetComponent<PlayerScript>().defense=defense;
    }

    public void LoadThisStuff()
    {
          player = GameObject.FindWithTag("Player");
        gameObject.GetComponentInChildren<UIToggle>().pauseMenu = player.GetComponentInChildren<pausemenu>();
        player.GetComponentInChildren<pausemenu>().uiToggle = gameObject.GetComponentInChildren<UIToggle>();
        player.GetComponent<Combat>().meleeAttacks = meleeHitboxes;
        player.GetComponent<Combat>().magicAttacks = rangeHitboxes;
        PlayerScript temp =player.GetComponent<PlayerScript>();
        temp.lvText = lvText;
        temp.spText = spText;
        temp.healthText = healthText;
        temp.shieldUnlocked = shieldUnlocked;
        temp.lv = lv;
        temp.hp = maxhp;
        temp.moveSpeed = moveSpeed;
        temp.attack = attack;
        temp.defense = defense;
    }

}