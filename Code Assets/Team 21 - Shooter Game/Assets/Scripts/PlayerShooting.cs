using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    float timeSinceShot = 0f;
    public float ShotTimer = 5f;
    public GameObject bullet;
    GameObject[] bullets = new GameObject[10];

    void Start() {
        for (int i = 0; i < bullets.Length; i++)
        {
            bullets[i] = Instantiate(bullet);
        }
        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(false);
        }
	}
	
	void Update () {
        timeSinceShot += Time.deltaTime;
        if (timeSinceShot >= ShotTimer)
        {
            foreach (GameObject bullet in bullets)
            {
                if (!bullet.activeInHierarchy)
                {
                    bullet.SetActive(true);
                    bullet.transform.position = transform.position;
                    bullet.transform.rotation = transform.rotation;
                    break;
                }
            }
            timeSinceShot = 0f;
        }
	}
}
