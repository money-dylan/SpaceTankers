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

public class EnemyShoot : MonoBehaviour
{

    public int counter = 1000;

    public PlayerShoot ProjectilePrefab;
    public Transform EnemyLaunch;
    public GameObject Player;

    //public int frequency = 7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerLocation = Player.transform.position;

        Vector3 alienPoint = EnemyLaunch.transform.position;

        Vector2 offset = new Vector2(playerLocation.x - alienPoint.x, playerLocation.y - alienPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        EnemyLaunch.transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (counter == 0)
        {
            Instantiate(ProjectilePrefab, EnemyLaunch.position, EnemyLaunch.transform.rotation);
            counter = 1000;
        }

       // Debug.Log(EnemyLaunch.transform.rotation);

        counter--;

    }
}
