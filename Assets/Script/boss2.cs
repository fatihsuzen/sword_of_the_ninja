using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss2 : MonoBehaviour
{
    int disable_boss = 0;

    public GameObject gameObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "sword")
        {

            if (disable_boss >= 5)
                gameObject.SetActive(false);
            disable_boss++;


        }
        Destroy(collision.gameObject);
    }
}
