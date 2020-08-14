using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlay : MonoBehaviour
{
    public Text swordtext;
    int i;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

        i = System.Convert.ToInt32(swordtext.text);

    }
    public void swordplay()
    { 
        
        if (i > 0)
        {
            GetComponent<AudioSource>().Play();
        }


    }
    public void play()
    {
            GetComponent<AudioSource>().Play();
        
    }
}
