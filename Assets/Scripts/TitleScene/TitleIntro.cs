using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using TMPro;
using System.Collections;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public float Speed = 0.1f;
    public TextMeshProUGUI producedBy;
    public TextMeshProUGUI overtake;
    public TextMeshProUGUI motto;
    public Button startButton;
    public Button skillAnalyzerButton;
    public Button settingButton;
    public Image BG;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;
    public void ChangeScene(int sceneNumber)
    {
        switch(sceneNumber)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }

    private IEnumerator FadeIn(Graphic obj, System.Action onComplete = null)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;
        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;
            float alphaValue = Mathf.Lerp(0, 1, percent);
            obj.color = new Color(obj.color.r, obj.color.g, obj.color.b, alphaValue);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        onComplete?.Invoke();
    }

    private IEnumerator FadeOut(Graphic obj, System.Action onComplete = null)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;
        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;
            float alphaValue = Mathf.Lerp(1, 0, percent);
            obj.color = new Color(obj.color.r, obj.color.g, obj.color.b, alphaValue);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        onComplete?.Invoke();
    }

    private IEnumerator FadeInColor(Graphic obj)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;
        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;
            float rgbValue = Mathf.Lerp(0, 1, percent);
            obj.color = new Color(rgbValue, rgbValue, rgbValue);
            yield return null;
        }
    }

    private IEnumerator FadeOutColor(Graphic obj)
    {
        float CurrentTime = 0.0f;
        float Percent = 0.0f;
        while (Percent < 1)
        {
            CurrentTime += Time.deltaTime;
            Percent = CurrentTime / fadeTime;
            float RGBValue = Mathf.Lerp(1, 0, Percent);
            obj.color = new Color(RGBValue, RGBValue, RGBValue);
            yield return null;
        }
    }


    private void Awake()
    {
        producedBy.gameObject.SetActive(true);
        StartCoroutine(FadeIn(producedBy, () => StartCoroutine(FadeOut(producedBy))));
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }
}
