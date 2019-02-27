using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : BaseWeapon
{



    public override void SetupWeapon()
    {
        weaponType = "Shotgun";
        minRange = 5f;
        maxRange = 10f;
        ShotTimer = 5f;
        Ammo = 8;

        damage = 10;


    }


    public override void Fire()
    {
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                bullet.GetComponent<BulletController>().damage = damage;
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                break;
            }
        }
    }
}
