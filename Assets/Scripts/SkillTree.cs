using UnityEngine;
using TMPro;

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

    int atkCounter;
    int defCounter;
    int speedCounter;
    int hpCounter;

    int fireballChecker;
    int poisonChecker;

    int reactShieldChecker;
    int placeShieldChecker;

    int requireVal;

    public void atkButonPressed()
    {
        atkCounter++;
        atkNumberText.text = "Atk" + atkCounter + "";
    }

    public void defButonPressed()
    {
        defCounter++;
        defNumberText.text = "Def" + defCounter + "";
    }

    public void speedButonPressed()
    {
        speedCounter++;
        speedNumberText.text = "Speed" + speedCounter + "";
    }

    public void hpButonPressed()
    {
        hpCounter++;
        hpNumberText.text = "HP" + hpCounter + "";
    }

    public void fireballButtonPressed()
    {
        fireballChecker++;
        fireballText.color = Color.gray;
    }

    public void poisonButtonPressed()
    {
        poisonChecker++;
        poisonText.color = Color.gray;
    }

    public void reactShieldButtonPressed()
    {
        reactShieldChecker++;
        reactShieldText.color = Color.gray;
    }

    public void placeShieldButtonPressed()
    {
        placeShieldChecker++;
        placeShieldText.color = Color.gray;
    }

}
