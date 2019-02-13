using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : BaseWeapon
{



    // Use this for initialization
    void Start()
    {
        weaponType = "Revolver";
        minRange = 5f;
        maxRange = 10f;
        ShotTimer = 2.5f;

        WeaponSwitching.baseWeapons.Add(this);

    }

    // Update is called once per frame
    void Update()
    {


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
