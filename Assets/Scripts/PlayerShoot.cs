using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 

  /$$$$$$     /$$$$$ /$$$$$$$$     /$$   /$$            /$$$$$$                           
 /$$__  $$   |__  $$|__  $$__/    | $$$ | $$           /$$__  $$                          
| $$  \__/      | $$   | $$       | $$$$| $$  /$$$$$$ | $$  \ $$ /$$$$$$$   /$$$$$$       
|  $$$$$$       | $$   | $$       | $$ $$ $$ /$$__  $$| $$  | $$| $$__  $$ /$$__  $$      
 \____  $$ /$$  | $$   | $$       | $$  $$$$| $$  \ $$| $$  | $$| $$  \ $$| $$$$$$$$      
 /$$  \ $$| $$  | $$   | $$       | $$\  $$$| $$  | $$| $$  | $$| $$  | $$| $$_____/      
|  $$$$$$/|  $$$$$$/   | $$       | $$ \  $$|  $$$$$$/|  $$$$$$/| $$  | $$|  $$$$$$$      
 \______/  \______/    |__//$$$$$$|__/  \__/ \______/  \______/ |__/  |__/ \_______/      
                          |______/                                                        
                                                                                          
 */

public class PlayerShoot : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D theRB;

    private bool bull = false;

    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0f, 0f, 90);
        bullet = GameObject.FindWithTag("bullet");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * Time.deltaTime * Speed;

        theRB.velocity = transform.right * Speed;

        if (bull == true)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.tag == "Cow")
        {
            Destroy(other.gameObject);
            bull = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
