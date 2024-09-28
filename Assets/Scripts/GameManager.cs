using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _instance;
    public static GameManager GetInstance()
    {
        Init();
        return _instance;
    }

    static void Init()
    {
        if (_instance == null)
        {
            GameObject gameObject = GameObject.Find("GameManager");

            if (gameObject == null)
            {
                gameObject = new GameObject { name = "GameManager" };
            }
            if (gameObject.GetComponent<GameManager>() == null)
            {
                gameObject.AddComponent<GameManager>();
            }
            DontDestroyOnLoad(gameObject);
            _instance = gameObject.GetComponent<GameManager>();
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
