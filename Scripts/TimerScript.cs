
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour
{
    static float timeLeft = 300.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
    }

    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60F);
        int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 8, 100, 100), "Time Left:" + niceTime);
    }

    public void ResetTime()
    {
        timeLeft = 300.0f;
    }

}

