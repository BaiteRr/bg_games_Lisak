using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    private bool isPause, isPlay;
    public GameObject pause, play;

    public void SetPause()
    {
        if (!isPause)
        {
            Time.timeScale = 0f;            
            isPause = true;
            isPlay = false;
            pause.SetActive(false);
            play.SetActive(true);            
        } else
        {
            Time.timeScale = 1f;
        }
        isPause = !isPause;
    }

    public void SetPlay()
    {
        if (!isPlay)
        {
            Time.timeScale = 1f;
            isPlay = false;
            pause.SetActive(true);
            play.SetActive(false);
        } else
        {
            Time.timeScale = 0f;
        }
        isPlay = !isPlay;        
    }
}
