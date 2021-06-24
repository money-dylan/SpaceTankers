using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeShot : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D theRB;

    private bool bull = false;

    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.FindWithTag("bullet");
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.right * Speed;

        if (bull == true)
        { 
            gameObject.SetActive(false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
   
        Destroy(other.gameObject);
        bull = true;
    }
}

