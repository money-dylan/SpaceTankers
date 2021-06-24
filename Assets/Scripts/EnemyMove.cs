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

public class EnemyMove : MonoBehaviour
{
    public int AlienSpeed = 5;

    public Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        theRB.velocity = transform.right * AlienSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > 10)
        {
            theRB.velocity = -transform.right * AlienSpeed;
        }
        else if (gameObject.transform.position.x < -10)
        {
            theRB.velocity = transform.right * AlienSpeed;
        }
        //Debug.Log(gameObject.transform.position.x);
    }
}
