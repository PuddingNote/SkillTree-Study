using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public SkillManager skillManager;

    private void Start()
    {
        skillManager = GameObject.FindObjectOfType<SkillManager>();
    }

    public void PressUpgradeButton()
    {
        skillManager.ChooseSkill(skillManager.activateSkill.skillid);
    }

}
