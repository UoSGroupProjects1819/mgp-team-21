using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : BaseWeapon
{



    // Use this for initialization
    public override void SetupWeapon()
    {
        weaponType = "Revolver";
        minRange = 5f;
        maxRange = 10f;
        ShotTimer = 2.5f;
        Ammo = 6;

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
