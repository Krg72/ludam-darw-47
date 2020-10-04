using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    public AudioClip btnclip;
    AudioSource audioSource;

    public static audioscript instance;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(btnclip);
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {
        //audiosource.PlayOneShot(theme);
    }
}
