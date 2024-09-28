using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    static BGMManager _instance;

    public static BGMManager GetInstance()
    {
        Init();
        return _instance;
    }

    static void Init()
    {
        if (_instance == null)
        {
            GameObject gameObject = GameObject.Find("BGMManager");

            if (gameObject == null)
            {
                gameObject = new GameObject { name = "BGMManager" };
            }
            if (gameObject.GetComponent<BGMManager>() == null)
            {
                gameObject.AddComponent<BGMManager>();
            }
            DontDestroyOnLoad(gameObject);
            _instance = gameObject.GetComponent<BGMManager>();
        }
    }

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }
}
