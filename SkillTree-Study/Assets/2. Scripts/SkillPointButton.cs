using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPointButton : MonoBehaviour
{
    public SkillManager skillManager;

    private void Start()
    {
        skillManager = GameObject.FindObjectOfType<SkillManager>();
    }

    public void PressSkillpointButton()
    {
        skillManager.PlusSkillPoint();
    }
}
