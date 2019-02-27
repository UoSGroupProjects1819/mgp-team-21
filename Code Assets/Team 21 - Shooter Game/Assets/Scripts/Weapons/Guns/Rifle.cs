using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : BaseWeapon {



    // Use this for initialization
    public override void SetupWeapon()
    {
        weaponType = "Rifle";
        minRange = 10f;
        maxRange = 25f;
        ShotTimer = 10f;
        Ammo = 15;

        damage = 10;


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
