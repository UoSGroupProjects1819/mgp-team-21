using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : BaseWeapon
{



    // Use this for initialization
    void Start()
    {
        weaponType = "Machine Gun";
        minRange = 10f;
        maxRange = 15f;
        ShotTimer = 0.1f;

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
