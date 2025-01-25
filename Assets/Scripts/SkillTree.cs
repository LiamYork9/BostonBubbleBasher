using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{

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

    int atkCounter;
    int defCounter;
    int speedCounter;
    int hpCounter;

    int fireballChecker;
    int poisonChecker;

    int reactShieldChecker;
    int placeShieldChecker;

    int telepopChecker;
    int soapChecker;

    int healChecker;
    int heal2Checker;

    public int requireVal = 0;

    public void atkButonPressed()
    {
        if (requireVal >= 1)
        {
            atkCounter++;
            atkNumberText.text = "Atk" + atkCounter + "";
            requireVal--;
        }
    }

    public void defButonPressed()
    {
        if (requireVal >= 1)
        {
            defCounter++;
            defNumberText.text = "Def" + defCounter + "";
            requireVal--;
        }
    }

    public void speedButonPressed()
    {
        if (requireVal >= 1)
        {
            speedCounter++;
            speedNumberText.text = "Speed" + speedCounter + "";
            requireVal--;
        }
    }

    public void hpButonPressed()
    {
        if (requireVal >= 1)
        {
            hpCounter++;
            hpNumberText.text = "HP" + hpCounter + "";
            requireVal--;
        }
    }

    public void fireballButtonPressed()
    {
        if (requireVal >= 1)
        {
            fireballChecker++;
            fireballText.color = Color.gray;
            requireVal--;
            Button fireBallButton = fireButton.GetComponent<Button>();
            fireBallButton.enabled = false;
        }
    }

    public void poisonButtonPressed()
    {
        if (requireVal >= 1)
        {
            poisonChecker++;
            poisonText.color = Color.gray;
            requireVal--;
            Button poisonButton = poisonButt.GetComponent<Button>();
            poisonButton.enabled = false;
        }
    }

    public void reactShieldButtonPressed()
    {
        if (requireVal >= 1)
        {
            reactShieldChecker++;
            reactShieldText.color = Color.gray;
            requireVal--;
            Button reactShieldButton = reactShieldButt.GetComponent<Button>();
            reactShieldButton.enabled = false;
        }
    }

    public void placeShieldButtonPressed()
    {
        if (requireVal >= 1)
        {
            placeShieldChecker++;
            placeShieldText.color = Color.gray;
            requireVal--;
            Button placeShieldButton = placeShieldButt.GetComponent<Button>();
            placeShieldButton.enabled = false;
        }
    }

    public void telepopButtonPressed()
    {
        if (requireVal >= 1)
        {
            telepopChecker++;
            telepopText.color = Color.gray;
            requireVal--;
            Button telepopButton = telepopButt.GetComponent<Button>();
            telepopButton.enabled = false;
        }
    }

    public void soapButtonPressed()
    {
        if (requireVal >= 1)
        {
            soapChecker++;
            soapText.color = Color.gray;
            requireVal--;
            Button soapButton = soapButt.GetComponent<Button>();
            soapButton.enabled = false;
        }
    }

    public void healButtonPressed()
    {
        if (requireVal >= 1)
        {
            healChecker++;
            healText.color = Color.gray;
            requireVal--;
            Button healButton = healButt.GetComponent<Button>();
            healButton.enabled = false;
        }
    }

    public void heal2ButtonPressed()
    {
        if (requireVal >= 1)
        {
            heal2Checker++;
            heal2Text.color = Color.gray;
            requireVal--;
            Button heal2Button = heal2Butt.GetComponent<Button>();
            heal2Button.enabled = false;
        }
    }

}
