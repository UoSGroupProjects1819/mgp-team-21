using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour {
    
    protected string weaponType;
    public float minRange;
    public float maxRange;
    public int damage;

    public float ShotTimer;

    protected static GameObject[] bullets = new GameObject[100];

    public int Ammo = 10;


    public static void CreateBullets(GameObject bullet)
    {
        for (int i = 0; i < bullets.Length; i++)
        {
            bullets[i] = Instantiate(bullet);
            bullets[i].GetComponent<BulletController>().shooter = Blackboard.GetGlobalGameObject("Player");
            bullets[i].SetActive(false);
        }
    }

    public abstract void SetupWeapon();
    public virtual void Fire()
    {
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.transform.position = transform.position;
                bullet.GetComponent<BulletController>().shooter = gameObject;
                bullet.SetActive(true);
                bullet.GetComponent<BulletController>().damage = damage;
                break;
            }
        }
    }



}
