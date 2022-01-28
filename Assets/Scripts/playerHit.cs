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

public class playerHit : MonoBehaviour
{
    public int counter = 0;
    public bool dead = false;

    private GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D player)
    {

        counter++;
       if (counter == 1)
       {
           Destroy(GameObject.FindWithTag("health1"));
       }
       if (counter == 2)
       {
           Destroy(GameObject.FindWithTag("health2"));
       }
       if (counter == 3)
       {
           Destroy(GameObject.FindWithTag("health3"));
           GameObject.FindWithTag("Player").SetActive(false);
           button.SetActive(true);
           Time.timeScale = 0;
       }

    }

}