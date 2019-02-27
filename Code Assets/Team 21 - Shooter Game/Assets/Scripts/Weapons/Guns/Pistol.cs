using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : BaseWeapon {

    // Use this for initialization
    public override void SetupWeapon()
    {
        weaponType = "Pistol";
        minRange = 5f;
        maxRange = 10f;
        ShotTimer = 1f;
        Ammo = 7;

        damage = 5;



    }


    public override void Fire()
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
    }
}
