using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firestar : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Rigidbody2D bullet;

	[SerializeField]
	private Rigidbody2D bullet2;

	[SerializeField]
    private Transform barrel;
	public GameObject GameObject;
    private float bulletSpeed= 1000f;
	public float sword;
	public Text swordtext;
	public Text scoretext;
	int bonus = 0,bonus1 = 0, bonus2 = 0, bonus3 = 0, bonus4 = 0, bonus5 = 0, bonus6 = 0, bonus7 = 0, bonus8 = 0, bonus9 = 0;

	void Start()
    {
		sword = 20f;
	}

    // Update is called once per frame
    void Update()
    {	
		swordtext.text = sword + "";

		if (Convert.ToInt32(scoretext.text) >= 200 && Convert.ToInt32(scoretext.text) <= 250)
		{
			GameObject.SetActive(true);

		}
		else
			GameObject.SetActive(false);



		if (Convert.ToInt32(scoretext.text)>=200)
        {
			

		}
        int i = System.Convert.ToInt32(scoretext.text);
        if (i > 200 && i < 500)
        {
			if (bonus == 0)
				sword += 5;
			    bonus++;
		}
		else if (i > 500 && i < 1000)
        {
			if (bonus1 == 0)
				sword += 5;
			bonus1++;
		}
		else if (i > 1000 && i < 1500)
        {
			if (bonus2 == 0)
				sword += 5;
			bonus2++;
		}
		else if (i > 1500 && i < 2000)
        {
			if (bonus3 == 0)
				sword += 5;
			bonus3++;
		}
		else if (i > 2000 && i < 2500)
        {
			if (bonus4 == 0)
				sword += 5;
			bonus4++;
		}
		else if (i > 2500 && i < 3000)
        {
			if (bonus5 == 0)
				sword += 5;
			bonus5++;
		}
		else if (i > 3000 && i < 3500)
        {
			if (bonus6 == 0)
				sword += 10;
			bonus6++;
		}
		else if (i > 3500 && i < 4000)
        {
			if (bonus7 == 0)
				sword += 10;
			bonus7++;
		}
		else if (i > 4000 && i < 4500)
        {
			if (bonus8 == 0)
				sword += 10;
			bonus8++;
		}
		else if (i > 4500 && i < 5000)
        {
			if (bonus9 == 0)
				sword += 20;
			bonus9++;
		}


    }
	public void left()
	{

		//loop over every touch found

		//move left
		if (sword > 0)
		{
			var spawnBullet = Instantiate(bullet2, barrel.position, barrel.rotation);
			spawnBullet.AddForce(-barrel.right * bulletSpeed);
		}

		if (sword>0)
		sword--;


	}
	public void right()
	{

		//loop over every touch found
		
			//move right
		if(sword > 0)
        {
			var spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
			spawnBullet.AddForce(barrel.right * bulletSpeed);
		}
			

		if(sword>0)
		sword--;
		
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "sword")
		{
			Destroy(collision.gameObject);
		}
		

	}
}
