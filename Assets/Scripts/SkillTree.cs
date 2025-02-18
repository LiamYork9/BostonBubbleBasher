using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class SkillTree : MonoBehaviour
{
    public PlayerScript player;

    public Spells spells;

    public TextMeshProUGUI atkNumberText;
    public TextMeshProUGUI defNumberText;
    public TextMeshProUGUI speedNumberText;
    public TextMeshProUGUI hpNumberText;

    public TextMeshProUGUI fireballText;
    public TextMeshProUGUI poisonText;

    public TextMeshProUGUI reactShieldText;
    public TextMeshProUGUI placeShieldText;

    public TextMeshProUGUI telepopText;
    public TextMeshProUGUI soapText;

    public TextMeshProUGUI healText;
    public TextMeshProUGUI heal2Text;

    public GameObject fireButton;
    public GameObject poisonButt;
    public GameObject reactShieldButt;
    public GameObject placeShieldButt;
    public GameObject telepopButt;
    public GameObject soapButt;
    public GameObject healButt;
    public GameObject heal2Butt;

    //Stats
    int atkCounter = 5;
    int defCounter = 1;
    int speedCounter = 5;
    int hpCounter = 10;

    int fireballChecker = 0;
    int poisonChecker = 0;

    int reactShieldChecker = 0;
    int placeShieldChecker = 0;

    int telepopChecker = 0;
    int soapChecker = 0;

    int healChecker = 0;
    int heal2Checker = 0;

    //Skill Points
    //public int requireVal = skillPoint;

   

    public void atkButonPressed()
    {
        if (player.skillPoint >= 1)
        {
            atkCounter++;
            atkNumberText.text = "Atk:" + atkCounter + "";
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
        }
    }

    public void defButonPressed()
    {
        if (player.skillPoint >= 1)
        {
            defCounter++;
            defNumberText.text = "Def:" + defCounter + "";
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
        }
    }

    public void speedButonPressed()
    {
        if (player.skillPoint >= 1)
        {
            speedCounter++;
            speedNumberText.text = "Speed:" + speedCounter + "";
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
        }
    }

    public void hpButonPressed()
    {
        if (player.skillPoint >= 1)
        {
            hpCounter++;
            hpNumberText.text = "HP:" + hpCounter + "";
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
        }
    }

    public void fireballButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            fireballChecker++;
            spells.UnlockFireball();
            fireballText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button fireBallButton = fireButton.GetComponent<Button>();
            fireBallButton.enabled = false;
        }
    }

    public void poisonButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            poisonChecker++;
            spells.UnlockPoison();
            poisonText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button poisonButton = poisonButt.GetComponent<Button>();
            poisonButton.enabled = false;
        }
    }

    public void reactShieldButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            reactShieldChecker++;
            spells.UnlockReactiveShield();
            reactShieldText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button reactShieldButton = reactShieldButt.GetComponent<Button>();
            reactShieldButton.enabled = false;

        }
    }

    public void placeShieldButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            placeShieldChecker++;
            placeShieldText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button placeShieldButton = placeShieldButt.GetComponent<Button>();
            placeShieldButton.enabled = false;
        }
    }

    public void telepopButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            telepopChecker++;
            telepopText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button telepopButton = telepopButt.GetComponent<Button>();
            telepopButton.enabled = false;
        }
    }

    public void soapButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            soapChecker++;
            //spells.UnlockSoap();
            soapText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button soapButton = soapButt.GetComponent<Button>();
            soapButton.enabled = false;
        }
    }

    public void healButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            healChecker++;
            healText.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button healButton = healButt.GetComponent<Button>();
            healButton.enabled = false;
        }
    }

    public void heal2ButtonPressed()
    {
        if (player.skillPoint >= 1)
        {
            heal2Checker++;
            heal2Text.color = Color.gray;
            GameManager.Instance.UpdateSkillPoint(player.skillPoint-1);
            Button heal2Button = heal2Butt.GetComponent<Button>();
            heal2Button.enabled = false;
        }
    }

    public void atkUp()
    {
        GameManager.Instance.UpdateAttack(GameManager.Instance.attack+1);
    }

    public void defUp()
    {
        GameManager.Instance.UpdateDefense(GameManager.Instance.defense+1);
    }

    public void speedUp()
    {
        GameManager.Instance.UpdateSpeed(GameManager.Instance.moveSpeed+1);
    }

    public void hpUp()
    {
        GameManager.Instance.UpdateMaxHP(GameManager.Instance.maxhp+1);
    }

    public void Update()
    {
        if (atkCounter > player.attack)
        {
        atkUp();
        }
        if (defCounter > player.defense)
        {
        defUp();
        }
        if (speedCounter > player.moveSpeed)
        {
        speedUp();
        }
        if (hpCounter > player.hp)
        {
        hpUp();
        }
    }

    public void Awake()
    {
        player = GameManager.Instance.player.GetComponent<PlayerScript>();
    }

}
