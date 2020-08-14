using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class active_boss : MonoBehaviour
{
    public Text Text;
    public GameObject gameObject;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    int gameObject_0 = 0;
    int gameObject_1 = 0;
    int gameObject_2 = 0;
    int gameObject_3 = 0;
    int gameObject_4 = 0;
    
    // Update is called once per frame
    void Update()
    {
        int i = System.Convert.ToInt32(Text.text);
        if (i == 1)
        {
            if(gameObject_0 == 0)
            { gameObject.active = true; }

            gameObject_0++;


        }
        if (i == 2)
        {
            if (gameObject_1 == 0)
            { gameObject1.active = true; }

            gameObject_1++;


        }
        if (i == 3)
        {
            if (gameObject_2 == 0)
            { gameObject2.active = true; }

            gameObject_2++;


        }
        if (i == 4)
        {
            if (gameObject_3 == 0)
            { gameObject3.active = true; }

            gameObject_3++;


        }
        if (i == 5)
        {
            if (gameObject_4 == 0)
            { gameObject4.active = true; }

            gameObject_4++;


        }
    }
}
