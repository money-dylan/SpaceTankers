using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Acting : MonoBehaviour
{
    public Rigidbody2D theRB;
    public Rigidbody2D fakeRB;

    private bool bulletFired = false;
    private int skip = 0;

    GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        //anger = GameObject.Find("Anger");
        bullet = GameObject.Find("PFBullet");
        bullet.SetActive(false);
        //anger.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 3.0727)
        {
            theRB.velocity = -transform.up * 5;
        }
        else
        {
            theRB.velocity = Vector3.zero;
        }

        if (gameObject.transform.position.y < 3.07 && skip == 0)
        {
            bullet.SetActive(true);
            bulletFired = true;
            skip++;
        }

        if (fakeRB.transform.position.x < 2.074867)
        {
            fakeRB.velocity = transform.right * 5;
        }
        else
        {
            theRB.velocity = Vector3.zero;
        }

        if (fakeRB.position.x > -6.7 && bulletFired == true)
        {
            SceneManager.LoadScene(2);
        }

        Debug.Log(fakeRB.transform.position.x);
    }

}
