using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    int disable_boss = 0;

    public GameObject gameObject;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "sword")
        {
            
            if (disable_boss >= 3)
                gameObject.SetActive(false);           
            disable_boss++;

                      
        }
        Destroy(collision.gameObject);
    }
}
