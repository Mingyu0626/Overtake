using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAnimation : MonoBehaviour
{

    public GameObject Left;
    public GameObject Right;
    public bool IsAnimationOpened = false;

    public void OpenSceneAnimation()
    {
        LeanTween.moveX(Left, Left.transform.position.x - 10f, 1f).setEaseOutQuad();
        LeanTween.moveX(Right, Right.transform.position.x + 10f, 1f).setEaseOutQuad().setOnComplete(OnAnimationComplete);
    }

    public void CloseSceneAnimation()
    {
        LeanTween.moveX(Left, Left.transform.position.x + 10f, 1f).setEaseOutQuad();
        LeanTween.moveX(Right, Right.transform.position.x - 10f, 1f).setEaseOutQuad().setOnComplete(OnAnimationComplete);
    }

    private void OnAnimationComplete()
    {
        Debug.Log("OpenSceneAnimation or CloseSceneAnimation Complete");
        if (!IsAnimationOpened) IsAnimationOpened = true;
        else IsAnimationOpened = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!IsAnimationOpened)
        {
            OpenSceneAnimation();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
