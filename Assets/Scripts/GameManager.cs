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

    public void UnlockShield()
    {
        shieldUnlocked = true;
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        gameObject.GetComponentInChildren<UIToggle>().pauseMenu = player.GetComponentInChildren<pausemenu>();
        player.GetComponentInChildren<pausemenu>().uiToggle = gameObject.GetComponentInChildren<UIToggle>();
        player.GetComponent<Combat>().meleeAttacks = meleeHitboxes;
        player.GetComponent<Combat>().magicAttacks = rangeHitboxes;
        player.GetComponent<PlayerScript>().lvText = lvText;
        player.GetComponent<PlayerScript>().spText = spText;
        player.GetComponent<PlayerScript>().healthText = healthText;
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
}