using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public int skillid;
    public string skillName;
    public Sprite skillSprite;

    [TextArea(1, 3)]
    public string skillDescription;
    public bool isUpgrade;
    public Skill[] unlockSkills;
}
