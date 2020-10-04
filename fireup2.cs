using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireup2 : MonoBehaviour
{
    public GameObject[] firebuttons;
    public GameObject door;
    public int i = 0;
    public int num_of_fires;
    public Rigidbody2D doorrb;

    AudioSource audioSource;
    public AudioClip fireclip;

    // Start is called before the first frame update
    void Start()
    {
        doorrb.isKinematic = true;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (i < num_of_fires)
        {
            firebuttons[i].SetActive(true);
           
        }


        if (i == num_of_fires - 1)
        {
            // door.SetActive(false);
            doorrb.isKinematic = false;
            doorrb.gravityScale = 1;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "reset")
        {
            i++;
            audioSource.PlayOneShot(fireclip);
        }
    }

    
}
