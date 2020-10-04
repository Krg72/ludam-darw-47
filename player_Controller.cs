using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_Controller : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    

    Vector2 originalpos;
    public GameObject originalposition;

    public GameObject pausepanel;
    AudioSource audioSource;
    public AudioClip levelclip;
    public canvascontrol canvas;

    private void Start()
    {
        originalpos = originalposition.transform.position;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

       

        for (int i = 0; i < 9; i++)
        {
            if(sceneName == "level " + i)
            {
                PlayerPrefs.SetFloat("highscore" + i, canvas.t);
            }
        }

        // PlayerPrefs.SetFloat("highscore2", canvas.t);

        /*  if (Input.GetButtonDown("Crouch"))
          {
              crouch = true;
          }
          else if (Input.GetButtonUp("Crouch"))
          {
              crouch = false;
          }*/

        if (Input.GetKey("escape"))
        {
            Time.timeScale = 0;
            pausepanel.SetActive(true);
        }

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "reset" || collision.collider.tag == "first"|| collision.collider.tag == "second"|| collision.collider.tag == "third")
        {
            transform.position = originalpos;
        }

        if(collision.collider.tag == "loadlevel")
        {
            audioSource.PlayOneShot(levelclip);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
