using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
//public Text timer;
    float time;
   // public GameObject pausepanel;
    public canvascontrol canvas;
    public Text lp1, lp2, lp3, lp4, lp5, lp6, lp7,lp8,lp9;

   // public float t;

    private void Start()
    {
       // time = Time.time;
        lp1.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f2");
        lp2.text = PlayerPrefs.GetFloat("highscore2", 0).ToString("f2");
        lp3.text = PlayerPrefs.GetFloat("highscore3", 0).ToString("f2");
        lp4.text = PlayerPrefs.GetFloat("highscore4", 0).ToString("f2");
        lp5.text = PlayerPrefs.GetFloat("highscore5", 0).ToString("f2");
        lp6.text = PlayerPrefs.GetFloat("highscore6", 0).ToString("f2");
        lp7.text = PlayerPrefs.GetFloat("highscore7", 0).ToString("f2");
        lp8.text = PlayerPrefs.GetFloat("highscore8", 0).ToString("f2");
        lp9.text = PlayerPrefs.GetFloat("highscore9", 0).ToString("f2");
    }

    private void Update()
    {
      /*  t = Time.time - time;
        string m = ((int)t / 60).ToString();
        string s = (t % 60).ToString("f2");

        if ((int)t / 60 > 0)
        {
            timer.text = m + ":" + s;
        }
        else
        {
            timer.text = s;
        }*/

    }
}
