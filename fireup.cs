using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireup : MonoBehaviour
{
    public GameObject[] firebuttons;
    public GameObject door;
    public int i = 0;
    public int num_of_fires;
    public Rigidbody2D doorrb;

    public bool first, second, third;

    public AudioClip doorclip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        doorrb.isKinematic = true;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(i < num_of_fires)
        {
            firebuttons[i].SetActive(true);
        }
        

        /*if(i == num_of_fires - 1)
        {
            // door.SetActive(false);
            doorrb.isKinematic = false;
            doorrb.gravityScale = 1;
        }*/

        if (first && second && third)
        {
            door.SetActive(false);
           // audioSource.PlayOneShot(doorclip);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "reset")
        {
            i = 1;
        }

        if (collision.collider.tag == "first")
        {
            first = true;
            i = 2;
        }

        if (collision.collider.tag == "second" && first)
        {
            second = true;
            i = 3;
        }

        if (collision.collider.tag == "third" && first && second)
        {
            third = true;
            i = 4;
        }
        if(second && collision.collider.tag == "first")
        {
            i = 1;
            firebuttons[2].SetActive(false);
            firebuttons[3].SetActive(false);
            first = false;
            second = false;
        }
        if (first && !second && collision.collider.tag == "third")
        {
            i = 1;
            firebuttons[2].SetActive(false);
            first = false;
        }

        

        /*if(collision.collider.tag == "first" || collision.collider.tag == "second")
        {
            i = 1;
            firebuttons[3].SetActive(false);
        }*/

    }
}
