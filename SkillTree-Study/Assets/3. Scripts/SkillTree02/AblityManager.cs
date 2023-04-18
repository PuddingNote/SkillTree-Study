using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AblityManager : MonoBehaviour
{
    public static AblityManager instance;

    public Ablity[] ablities;
    public AblityButton[] ablityButtons;

    public Ablity activateButton;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    //private void Start()
    //{
    //    remainPoints = totalPoints;
    //    DisplayPoints();
    //}

    //public void DisplayPoints()
    //{
    //    pointsText.text = remainPoints + "/11";
    //}

    //public void PressUpgrade()
    //{
    //    Debug.Log("Press Upgrade Button can work");
    //    if(remainPos >= 1)
    //    {
    //        Debug.Log("--Upgrade--");
    //        remainPos -= 1;
    //        activeSkill.isUpgrade = true;
    //    }
    //    else
    //    {
    //        Debug.Log("Not enough Skill Points");
    //    }

    //    DisplayPoints();
    //    UpdateAblityButton();

    //}

    //void UpdateAblityButton()
    //{
    //    for(int i=0;i<ablities.Length;i++)
    //    {
    //        if(ablities[i].isUpgrade)
    //        {
    //            ablities[i].GetComponent<Image>().color = new Vector4(1, 1, 1, 1);
    //            ablities[i].transfrom.GetChild(0).GetComponent<Image>().sprite = upgradeSprite;
    //        }
    //        else
    //        {
    //            ablities[i].GetComponent<Image>().color = new Vector4(0.15f, 0.45f, 0.45f, 1);
    //            ablities[i].transfrom.GetChild(0).GetComponent<Image>().sprite = normalSprite;
    //        }
    //    }
    //}


}
