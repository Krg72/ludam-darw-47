using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public Rigidbody2D bulletrb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bulletrb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
