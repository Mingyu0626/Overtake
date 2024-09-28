using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{

    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
