using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

public class mainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
