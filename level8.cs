using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level8 : MonoBehaviour
{
    Vector2 originalpos1;
    public GameObject resetpos1;

    public GameObject[] doors;
    //public GameObject[] buttons;
   // public int i;

   // public int num_of_fires;
    //  public Rigidbody2D doorrb;

    public AudioClip btnclip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource.GetComponent<AudioSource>();
        originalpos1 = resetpos1.transform.position;
                audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "btn1")
        {
            doors[0].SetActive(true);
            audioSource.PlayOneShot(btnclip);
            
        }

        if (collision.collider.tag == "btn2")
        {
            doors[1].SetActive(false);
            audioSource.PlayOneShot(btnclip);
        }
        if (collision.collider.tag == "reset")
        {
            transform.position = originalpos1;
        }
    }
}
