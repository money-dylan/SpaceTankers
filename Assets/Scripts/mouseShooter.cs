using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//tutorial used https://www.youtube.com/watch?v=xLtLwSgzOEo
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


public class mouseShooter : MonoBehaviour
{
    //private Camera theCam;

    //Projectiles
    public PlayerShoot ProjectilePrefab;
    public Transform LaunchOffset;

    // Start is called before the first frame update
    void Start()
    {

        //theCam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        //Debug.Log(screenPoint.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        //Shoot Projectile
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }
}
