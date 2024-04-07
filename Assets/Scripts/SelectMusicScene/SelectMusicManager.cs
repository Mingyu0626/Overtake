using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class SelectMusicSceneManager : MonoBehaviour
{
    [SerializeField] Music[] MusicList = null;
    [SerializeField] Text TextMusicTitle = null;
    [SerializeField] Text TextMusicComposer = null;
    [SerializeField] Text TextMusicBPM = null;
    [SerializeField] Image Img = null;
    [SerializeField] GameObject TitleMenu = null;

    int CurrentMusic = 0;

    public void ListUp()
    {
        CurrentMusic--;
        if (CurrentMusic < 0) CurrentMusic = MusicList.Length - 1;
    }

    public void ListDown()
    {
        CurrentMusic++;
        if (CurrentMusic >= MusicList.Length - 1) CurrentMusic = 0;
    }

    public void SetMusicInfo()
    {
        TextMusicTitle.text = MusicList[CurrentMusic].title;
        TextMusicComposer.text = MusicList[CurrentMusic].composer;
        TextMusicBPM.text = MusicList[CurrentMusic].bpm.ToString();
        Img.sprite = MusicList[CurrentMusic].sprite;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
