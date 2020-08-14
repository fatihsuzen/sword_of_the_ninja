using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ninja : MonoBehaviour
{
    public float hiz = 5f;
    private bool m_FacingRight = true;
    private Animator m_Animator;
    private float ScreenWidth;
    public float moveSpeed = 5f;
    public GameObject character;
    
    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        m_Animator = GetComponent < Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float axis_h = Input.GetAxis("Horizontal");
       
        m_Animator.SetFloat("hSpeed", Mathf.Abs(axis_h));

        if((axis_h <= -1 && !m_FacingRight) || (axis_h>=1 && m_FacingRight))
        { m_FacingRight = !m_FacingRight;
            if(axis_h <= -1)
           transform.localScale = new Vector3(-1.815416f, transform.localScale.y, transform.localScale.z);
            if (axis_h >= 1)
                transform.localScale = new Vector3(1.815416f, transform.localScale.y, transform.localScale.z);
        }


    }

   
}
   
    


