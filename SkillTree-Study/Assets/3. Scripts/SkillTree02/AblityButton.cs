using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AblityButton : MonoBehaviour
{
    public Text ablityNameText;
    public Text ablityDesText;
    public Image ablitySprite;

    public int buttonId;

    public void PressAblityButton()
    {
        ablityNameText.text = AblityManager.instance.ablities[buttonId].ablityName;
        ablityDesText.text = AblityManager.instance.ablities[buttonId].ablityDes;
        ablitySprite.sprite = AblityManager.instance.ablities[buttonId].ablitySprite;

        Debug.Log(buttonId);
    }

}
