﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level7 : MonoBehaviour
{
    Vector2 originalpos1, originalpos2;
    public GameObject resetpos1;

    public GameObject[] doors;
    //public GameObject[] buttons;
    public int i;

    public int num_of_fires;
    //  public Rigidbody2D doorrb;

    public AudioClip btnclip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        originalpos1 = resetpos1.transform.position;
        //originalpos2 = resetpos2.transform.position;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "first")
        {
            transform.position = originalpos1;
            //buttons[0].SetActive(true);
            //doors[0].SetActive(false);
            audioSource.PlayOneShot(btnclip);
        }
        if (collision.collider.tag == "btn1")
        {
            doors[0].SetActive(true);
            //transform.position = originalpos1;
            //buttons[0].SetActive(true);
            //doors[0].SetActive(false);
            audioSource.PlayOneShot(btnclip);
        }

    }
}
