using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLine : MonoBehaviour
{
    public Skill unlockSkillline;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
}
