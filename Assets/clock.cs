using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class clock : MonoBehaviour
{
    float TimeOut = 180f;
    float clockTime;
    // Start is called before the first frame update
    void Start()
    {
        clockTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        clockTime += Time.deltaTime;
        float RemainTime;
        RemainTime= TimeOut - clockTime;
        int minutes = Mathf.FloorToInt(RemainTime / 60f);
        int seconds = Mathf.FloorToInt(RemainTime - minutes * 60);
        int mseconds = Mathf.FloorToInt((RemainTime - minutes * 60 - seconds) * 1000);
        string niceTime = string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, mseconds);

        TextMeshProUGUI textmp = GetComponent<TextMeshProUGUI>();
        textmp.SetText(niceTime);
    }
}
