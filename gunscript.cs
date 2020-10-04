using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunscript : MonoBehaviour
{
    public GameObject bullet;
    public Transform firepoint;

    public float maxxammo = 5;
    public float currentammo;

    AudioSource audioSource;
    public AudioClip nailclip;
    public AudioClip nullclip;
    public Text ammo;

    // Start is called before the first frame update
    void Start()
    {
        currentammo = maxxammo;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentammo >= 0)
        {
            ammo.text = currentammo.ToString();
        }if(currentammo < 0)
        {
            ammo.text = "0";
        }
        

        Vector3 mousePos = Input.mousePosition;
        // mousePos.z = 5.23f;

        //transform.LookAt(mousePos);

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (Input.GetButtonDown("Fire1"))
        {
            if(currentammo > 0)
            {
                Instantiate(bullet, firepoint.position, firepoint.rotation);
                audioSource.PlayOneShot(nailclip);
            }if(currentammo <= 0)
            {
                audioSource.PlayOneShot(nullclip);
            }
            
            currentammo--;
            //  bulletrb.AddForce(transform.forward * 100);
            
        }
    }

}
