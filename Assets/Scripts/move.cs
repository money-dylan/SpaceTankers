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

public class move : MonoBehaviour
{
    //Movement
    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    public bool isGrounded = false;

    //Rotation
    //private bool pFacingRight = false;
    //private bool lastFacing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Call Jump Method
        Jump();
        //Horizontal Movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f,0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

       /* //Rotate player
        lastFacing = pFacingRight;

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            pFacingRight = true;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            pFacingRight = false;
        }

        if (pFacingRight != lastFacing)
        {
            transform.Rotate(0f, 180f, 0f);
        }
        */
    }

    void Jump()
    {
        //Jump on button press
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
