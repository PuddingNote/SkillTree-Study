using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    public Image skillImage;
    public Text skillNameText;
    public Text skillDesText;

    public int skillButtonId;

    public void PressSkillButton()
    {
        SkillManager.Instance.activateSkill = transform.GetComponent<Skill>();

        skillImage.sprite = SkillManager.Instance.skills[skillButtonId].skillSprite;
        skillNameText.text = SkillManager.Instance.skills[skillButtonId].skillName;
        skillDesText.text = SkillManager.Instance.skills[skillButtonId].skillDescription;
    }

}
