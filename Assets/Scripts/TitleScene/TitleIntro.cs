using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public float Speed = 0.1f;
    public TextMeshProUGUI ProducedBy;
    public TextMeshProUGUI Overtake;
    public TextMeshProUGUI Motto;
    public Button StartButton;
    public Button SkillAnalyzerButton;
    public Button SettingButton;
    public Image BG;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float FadeTime;
    private bool isProduceByBright = false;
    private bool isOvertakeReady = false;
    public void ChangeScene(int SceneNumber)
    {
        switch(SceneNumber)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }

    private IEnumerator Fade(float start, float end, Graphic tmp)
    {
        float CurrentTime = 0.0f;
        float Percent = 0.0f;
        while (Percent < 1)
        {
            CurrentTime += Time.deltaTime;
            Percent = CurrentTime / FadeTime;

            Color color = tmp.color;
            color.a = Mathf.Lerp(start, end, Percent);
            tmp.color = color;
            yield return null;
        }

        if (tmp.color.a == 1) isProduceByBright = true;
        else
        {
            isOvertakeReady = true;
            ProducedBy.gameObject.SetActive(false);
        }
    }

    private IEnumerator FadeColor(float start, float end, Graphic img)
    {
        float CurrentTime = 0.0f;
        float Percent = 0.0f;
        while (Percent < 1)
        {
            CurrentTime += Time.deltaTime;
            Percent = CurrentTime / FadeTime;

            Color color = img.color;
            color.r = Mathf.Lerp(start, end, Percent);
            color.g = Mathf.Lerp(start, end, Percent);
            color.b = Mathf.Lerp(start, end, Percent);
            img.color = color;
            yield return null;
        }
    }


    private void Awake()
    {
        ProducedBy.gameObject.SetActive(true);
        StartCoroutine(Fade(0, 1, ProducedBy));
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isProduceByBright) 
        {
            StartCoroutine(Fade(1, 0, ProducedBy));
        }
        if (isOvertakeReady)
        {
            StartCoroutine(Fade(0, 1, Overtake));
            StartCoroutine(Fade(0, 1, Motto));
            StartCoroutine(Fade(0, 1, SkillAnalyzerButton.GetComponent<Image>()));
            StartCoroutine(Fade(0, 1, StartButton.GetComponent<Image>()));
            StartCoroutine(Fade(0, 1, SettingButton.GetComponent<Image>()));
            StartCoroutine(FadeColor(0, 1, BG));
        }
    }
}
