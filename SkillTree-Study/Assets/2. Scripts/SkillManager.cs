using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public static SkillManager instance;

    public Skill[] skills;
    public SkillButton[] skillButtons;
    public Button[] buttons;

    public Skill activateSkill; // 선택한 스킬정보
    public GameObject uiPanel; // 스킬창UI

    private int skillPoints = 0; // 스킬포인트
    public Text skillPointsText; // 스킬포인트 UI

    public GameObject[] checkObject; // 개별스킬들 업그레이드 checkBox
    public SkillLine[] skillLines; // 스킬라인

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

        uiPanel.SetActive(false);

        for(int i=0;i<buttons.Length;i++)
        {   // 기본스킬 제외하고 비활성화
            if (i == 0 || i == 8) buttons[i].interactable = true;
            else buttons[i].interactable = false;

            checkObject[i].SetActive(false);
        }

        UpdateSkillPointsText();
    }

    public void Update()
    {
        if (activateSkill != null) ShowUI();
    }

    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }

    // 스킬포인트 추가
    public void PlusSkillPoint()
    {
        Debug.Log("스킬포인트 추가");
        skillPoints++;
        UpdateSkillPointsText();
    }

    // 스킬 업그레이드
    public void ChooseSkill(int skillIndex)
    {
        if (skillPoints > 0)
        {
            // 스킬 찍기 가능한 경우
            if (!skills[skillIndex - 1].isUpgrade)
            {
                Debug.Log("스킬 업그레이드 완료");
                skills[skillIndex - 1].isUpgrade = true; // isUpgrade를 true로 변경
                checkObject[skillIndex - 1].SetActive(true); // 업그레이드 체크박스 표시
                skillPoints--; // 스킬 포인트 감소
                UpdateSkillPointsText(); // 스킬포인트 UI 업데이트
                DrawSkillConnection(skillIndex - 1); // 스킬 연결선 그리기

                for(int i=0;i<skills[skillIndex - 1].unlockSkills.Length;i++)
                {   // 연결된 스킬 활성화
                    buttons[skills[skillIndex - 1].unlockSkills[i].skillid - 1].interactable = true;
                }

                for(int i=0;i<skillLines.Length;i++)
                {   // 필요한 스킬라인 활성화
                    if(skillLines[i].unlockSkillline == skills[skillIndex - 1])
                    {
                        skillLines[i].gameObject.SetActive(true);
                    }

                }

            }
            else
            {
                Debug.Log("이미 배운 스킬");
            }
        }
        else
        {
            Debug.Log("스킬포인트 부족");
        }
    }

    // 스킬 포인트 UI 업데이트 메서드
    void UpdateSkillPointsText()
    {
        if (skillPointsText != null)
        {
            skillPointsText.text = "SkillPoints : " + skillPoints;
        }
    }

    // 스킬 연결선 그리기 메서드
    void DrawSkillConnection(int skillIndex)
    {
        // 스킬 연결선 그리는 로직 작성
        // 스킬트리 UI에서 선택한 스킬과 이미 학습한 스킬들 간의 연결선을 그릴 수 있습니다.
    }

}
