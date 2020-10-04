using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3_reset : MonoBehaviour
    
{
    Vector2 originalpos1, originalpos2, originalpos3;
    public GameObject resetpos1, resetpos2, resetpos3;

    public GameObject[] firebuttons;
    public GameObject[] firebuttons2;
    public int i;

    public int num_of_fires;
    public Rigidbody2D doorrb;
  //  public AudioClip doorclip;
  //  AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        originalpos1 = resetpos1.transform.position;
        originalpos2 = resetpos2.transform.position;
        originalpos3 = resetpos3.transform.position;
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 1)
        {
            firebuttons[1].SetActive(true);
        }

        if (i == 2)
        {
            firebuttons[2].SetActive(false);
            //audioSource.PlayOneShot(doorclip);
        }
        if (i == 3)
        {
            firebuttons[3].SetActive(false);
            //audioSource.PlayOneShot(doorclip);
        }
        if (i == 4)
        {
            //audioSource.PlayOneShot(doorclip);
            firebuttons[4].SetActive(false);
        }

        if (i < num_of_fires)
        {
            firebuttons2[i].SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "reset2")
        {
            transform.position = originalpos1;
        }

        if (collision.collider.tag == "reset3")
        {
            transform.position = originalpos2;
        }

        if (collision.collider.tag == "reset")
        {
            i++;
        }
        if (collision.collider.tag == "first")
        {
            transform.position = originalpos3;
        
    }
    }
}
