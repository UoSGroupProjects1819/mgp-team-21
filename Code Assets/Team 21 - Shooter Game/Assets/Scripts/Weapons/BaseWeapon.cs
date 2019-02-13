using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour {

    protected string weaponType;
    public float minRange;
    public float maxRange;
    public int damage;

    public float ShotTimer;

    public GameObject bullet;
    protected GameObject[] bullets = new GameObject[10];

    void Start()
    {
        for (int i = 0; i < bullets.Length; i++)
        {
            bullets[i] = Instantiate(bullet);
        }
        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(false);
        }
    }

    public abstract void Fire();


    
}
