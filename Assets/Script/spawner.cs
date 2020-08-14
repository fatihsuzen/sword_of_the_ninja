using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    int whatToSpawn;
    public float small_random=1f;
    public float big_random = 2.5f;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    public Text scoretext, lvltext;
    public GameObject Object, Object1, Object2, Object3, Object4, bonus;        
    
    private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        for (int i = 0; i < 15; i++)
        {
                  Instantiate(Object, new Vector3(Random.Range(-9, 9),
                  Random.Range(rt.rect.yMin, rt.rect.yMax), 0) + rt.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Time.time >nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            switch(whatToSpawn)
            {
                case 1:
                    Instantiate(Object, new Vector3(Random.Range(-8f,8f), 8.00f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Object1, new Vector3(Random.Range(-8f, 8f), 8.00f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Object2, new Vector3(Random.Range(-8f, 8f), 8.00f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Object3, new Vector3(Random.Range(-8f, 8f), 8.00f), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Object4, new Vector3(Random.Range(-8f, 8f), 8.00f), Quaternion.identity);
                    break;                         

            }

            int i = System.Convert.ToInt32(scoretext.text);
                     
            if (i > 200 && i < 500)
            { 
                lvltext.text = 1+"";
                big_random = 1.9f;
                }
            else if (i > 500 && i < 1000)
            {
                lvltext.text = 2 + "";
                big_random = 1.6f;
                small_random = 0.9f;
            }
           else if (i > 1000 && i < 1500)
            {
                lvltext.text = 3 + "";
                big_random = 1.5f;
                small_random = 0.9f;
            }
            else if (i > 1500 && i < 2000)
            {
                lvltext.text = 4 + "";
                big_random = 1.4f;
                small_random = 0.9f;
            }
            else if (i > 2000 && i < 2500)
            {
                lvltext.text = 5 + "";
                big_random = 1.4f;
                small_random = 0.8f;
            }
            else if (i > 2500 && i < 3000)
            {
                lvltext.text = 6 + "";
                big_random = 1.4f;
                small_random = 0.7f;
            }
            else if (i > 3000 && i < 3500)
            {
                lvltext.text = 7 + "";
                big_random = 1.3f;
                small_random = 0.6f;
            }
            else if (i > 3500 && i < 4000)
            {
                lvltext.text = 8 + "";
                big_random = 1.2f;
                small_random = 0.5f;
            }
            else if (i > 4000 && i < 4500)
            {
                lvltext.text = 9 + "";
                big_random = 1.1f;
                small_random = 0.5f;
            }
            else if (i > 4500 && i < 5000)
            {
                lvltext.text = 10 + "";
                big_random = 1f;
                small_random = 0.4f;
            }
            else { }
                nextSpawn = Time.time + Random.Range(small_random,big_random);
        }
    }
}
