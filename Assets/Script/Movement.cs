using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
	//variables
	public float moveSpeed = 700;
	public GameObject character;
	private Animator m_Animator;
	private Rigidbody2D characterBody;
	private float ScreenWidth;
	private bool m_FacingRight = true;
	// Use this for initialization
	void Start()
	{
		ScreenWidth = Screen.width;
		characterBody = character.GetComponent<Rigidbody2D>();
		m_Animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		
		float axis_h = Input.GetAxis("Horizontal");

		if ((axis_h <= -1 && !m_FacingRight) || (axis_h >= 1 && m_FacingRight))
		{
			m_FacingRight = !m_FacingRight;
			if (axis_h <= -1)
				RunCharacter(-1.0f);
			if (axis_h >= 1)
				RunCharacter(1.0f);
		}

		
		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount)
		{
			
			if (Input.GetTouch(i).position.x > ScreenWidth / 2)
			{
				//move right
				
				RunCharacter(1.0f);
				}
			if (Input.GetTouch(i).position.x < ScreenWidth / 2)
			{
				//move left
				
				RunCharacter(-1.0f);

				}
			++i;
		}
		
	}
	void FixedUpdate()
	{
#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
		float axis_h = Input.GetAxis("Horizontal");
		m_Animator.SetFloat("hSpeed", Mathf.Abs(axis_h));
#endif
	}

	private void RunCharacter(float horizontalInput)
	{
		float axis_h = Input.GetAxis("Horizontal");
		m_Animator.SetFloat("hSpeed", Mathf.Abs(axis_h));
		if (horizontalInput <= -1)
		{
			m_Animator.SetFloat("hSpeed", 1);
			transform.localScale = new Vector2(-1f, transform.localScale.y);
		}
		else if (horizontalInput >= 1)
		{
			m_Animator.SetFloat("hSpeed", 1);
			transform.localScale = new Vector2(1f, transform.localScale.y);
		}
		else
		{
			m_Animator.SetFloat("hSpeed", -1);
		}
		characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));

	}
	/*private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "gem0")
		{
			Destroy(collision.gameObject);

		}
		if (collision.collider.tag == "gem1")
		{
			Destroy(collision.gameObject);

		}
		if (collision.collider.tag == "gem2")
		{
			Destroy(collision.gameObject);

		}
		if (collision.collider.tag == "gem3")
		{
			Destroy(collision.gameObject);

		}
		if (collision.collider.tag == "gem4")
		{
			Destroy(collision.gameObject);

		}
	}*/
	
}