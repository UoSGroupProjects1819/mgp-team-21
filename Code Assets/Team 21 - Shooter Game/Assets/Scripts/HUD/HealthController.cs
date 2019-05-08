using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {

    private Slider healthBar;
    public int health = 100;

    void Awake()
    {
        healthBar = GetComponent<Slider>();
    }




	
	// Update is called once per frame
	void Update ()
    {
        healthBar.value = health;
	}

    public void changeHP(int dHP)
    {
        health += dHP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= collision.gameObject.GetComponent<BulletController>().damage;
        }
    }

    
}
