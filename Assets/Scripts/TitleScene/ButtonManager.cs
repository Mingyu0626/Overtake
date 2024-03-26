using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject SettingUI;
    public void GoSelectMusicScene()
    {
        SceneManager.LoadScene("SelectMusicScene");
    }

    public void GoSkillAnalyzerScene()
    {
        SceneManager.LoadScene("SkillAnalyzerScene");
    }
    public void OnSettingMenu()
    {
        SettingUI.SetActive(true);

    }


    // Start is called before the first frame update
    void Start()
    {
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
