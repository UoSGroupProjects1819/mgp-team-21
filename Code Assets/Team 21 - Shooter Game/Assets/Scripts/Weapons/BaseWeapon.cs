using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour {
    
    protected string weaponType;
    public float minRange;
    public float maxRange;
    public int damage;

    public float ShotTimer;

    protected GameObject[] bullets = new GameObject[100];

    public int Ammo = 10;


    public virtual void CreateBullets(GameObject bullet)
    {
        for (int i = 0; i < bullets.Length; i++)
        {
            bullets[i] = Instantiate(bullet);
        }
        foreach (GameObject b in bullets)
        {
            b.SetActive(false);
        }
    }

    public abstract void SetupWeapon();
    public abstract void Fire();


    
}
