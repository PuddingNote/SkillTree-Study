using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    private static SkillManager instance = null;

    public Skill[] skills;
    public SkillButton[] skillButtons;
    public Button[] buttons;

    public Skill activateSkill;             // ������ ��ų����
    public GameObject uiPanel;              // ��ųâUI

    private int skillPoints = 0;            // ��ų����Ʈ
    public Text skillPointsText;            // ��ų����Ʈ UI

    public GameObject[] checkObject;        // ������ų�� ���׷��̵� checkBox
    public SkillLine[] skillLines;          // ��ų����

    public static SkillManager Instance
    {
        get
        {
            if (instance == null || instance == default)
            {
                return null;
            }
            return instance;
        }
    }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        uiPanel.SetActive(false);

        for(int i = 0; i < buttons.Length; i++)
        {   // �⺻��ų �����ϰ� ��Ȱ��ȭ
            if (i == 0 || i == 8)
            {
                buttons[i].interactable = true;
            }
            else
            {
                buttons[i].interactable = false;
            }

            checkObject[i].SetActive(false);
        }

        UpdateSkillPointsText();
    }

    public void Update()
    {
        if (activateSkill != null)
        {
            ShowUI();
        }
    }

    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }

    // ��ų����Ʈ �߰�
    public void PlusSkillPoint()
    {
        Debug.Log("��ų����Ʈ �߰�");
        skillPoints++;
        UpdateSkillPointsText();
    }

    // ��ų ���׷��̵�
    public void ChooseSkill(int skillIndex)
    {
        if (skillPoints > 0)
        {
            // ��ų ���׷��̵尡 ������ ���
            if (!skills[skillIndex - 1].isUpgrade)
            {
                Debug.Log("��ų ���׷��̵� �Ϸ�");
                skills[skillIndex - 1].isUpgrade = true;            // isUpgrade�� true�� ����
                checkObject[skillIndex - 1].SetActive(true);        // ���׷��̵� üũ�ڽ� ǥ��
                skillPoints--;                                      // ��ų ����Ʈ ����
                UpdateSkillPointsText();                            // ��ų����Ʈ UI ������Ʈ

                for (int i = 0; i < skills[skillIndex - 1].unlockSkills.Length; i++)
                {   // ����� ��ų Ȱ��ȭ
                    buttons[skills[skillIndex - 1].unlockSkills[i].skillid - 1].interactable = true;
                }

                for (int i = 0; i < skillLines.Length; i++)
                {   // �ʿ��� ��ų���� Ȱ��ȭ
                    if (skillLines[i].unlockSkillline == skills[skillIndex - 1])
                    {
                        skillLines[i].gameObject.SetActive(true);
                    }

                }

            }
            else
            {
                Debug.Log("�̹� ��� ��ų");
            }
        }
        else
        {
            Debug.Log("��ų����Ʈ ����");
        }
    }

    // ��ų ����Ʈ UI ������Ʈ �޼���
    void UpdateSkillPointsText()
    {
        if (skillPointsText != null)
        {
            skillPointsText.text = "SkillPoints : " + skillPoints;
        }
    }

}
