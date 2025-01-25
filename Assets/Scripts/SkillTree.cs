using UnityEngine;
using TMPro;

public class SkillTree : MonoBehaviour
{

    public TextMeshProUGUI atkNumberText;
    public TextMeshProUGUI defNumberText;
    public TextMeshProUGUI speedNumberText;
    public TextMeshProUGUI hpNumberText;
    int atkCounter;
    int defCounter;
    int speedCounter;
    int hpCounter;

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

}
