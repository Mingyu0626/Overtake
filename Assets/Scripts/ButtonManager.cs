using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject SettingUI;
    private ChangeSceneAnimation ChangeSceneAnimationScript;
    public void GoSelectMusicScene()
    {
        CloseAnimation("SelectMusicScene");
    }

    public void GoSkillAnalyzerScene()
    {
        CloseAnimation("SkillAnalyzerScene");
    }
    public void OnSettingMenu()
    {
        SettingUI.SetActive(true);

    }

    private void CloseAnimation(string SceneName)
    {
        if (ChangeSceneAnimationScript != null)
        {
            ChangeSceneAnimationScript.CloseSceneAnimation();

            // CloseAnimation()�� ����� �� 1�� �ڿ� üũ ����
            LeanTween.delayedCall(1.1f, () =>
            {
                if (CheckCompletelyClosed()) SceneManager.LoadScene(SceneName);
            });
        }

        else
        {
            Debug.LogError("ChangeSceneAnimation ��ũ��Ʈ�� ã�� �� �����ϴ�.");
        }
    }

    private bool CheckCompletelyClosed()
    {
        if (ChangeSceneAnimationScript != null && !ChangeSceneAnimationScript.IsAnimationOpened) return true;
        else return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeSceneAnimationScript = GetComponent<ChangeSceneAnimation>();
        SettingUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SettingUI.SetActive(false);
        }
    }
}
