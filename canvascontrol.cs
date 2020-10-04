using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class canvascontrol : MonoBehaviour
{
    public Text timer;
    float time;
    public GameObject pausepanel;
    //public Text lp1, lp2, lp3, lp4, lp5, lp6, lp7;
    
    public float t;

    private void Start()
    {
        time = Time.time;
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
        /* lp1.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f2");
         lp2.text = PlayerPrefs.GetFloat("highscore2", 0).ToString("f2");
         lp3.text = PlayerPrefs.GetFloat("highscore3", 0).ToString("f2");
         lp4.text = PlayerPrefs.GetFloat("highscore4", 0).ToString("f2");
         lp5.text = PlayerPrefs.GetFloat("highscore5", 0).ToString("f2");
         lp6.text = PlayerPrefs.GetFloat("highscore6", 0).ToString("f2");
         lp7.text = PlayerPrefs.GetFloat("highscore7", 0).ToString("f2");*/
    }

    private void Update()
    {
         t = Time.time - time;
        string m = ((int)t / 60).ToString();
        string s = (t % 60).ToString("f2");

        if ((int)t / 60 > 0)
        {
            timer.text = m + ":" + s;
        }
        else
        {
            timer.text = s;
        }

    }

    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menu()
    {
        SceneManager.LoadScene("menu");
    }

   public void resume()
    {
        Time.timeScale = 1f;
        pausepanel.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void loop1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 1");
    }

    public void loop2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 2");
    }

    public void loop3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 3");
    }

    public void loop4()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 4");
    }

    public void loop5()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 5");
    }
    public void loop6()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 6");
    }

    public void loop7()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 7");
    }
    public void loop8()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 8");
    }
    public void loop9()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 9");
    }

}
