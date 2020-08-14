using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
    public float scoreamont;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {

        scoreamont = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (int)scoreamont + "";
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "gem0")
        {
            scoreamont += 5;
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "gem1")
        {
            scoreamont += 10;
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "gem2")
        {
            scoreamont += 20;
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "gem3")
        {
            scoreamont += 30;
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "gem4")
        {
            scoreamont += 40;
            Destroy(collision.gameObject);
        }
    }

}
