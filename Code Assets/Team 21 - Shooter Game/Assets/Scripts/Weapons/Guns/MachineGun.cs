using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : BaseWeapon
{



    // Use this for initialization
    public override void SetupWeapon()
    {
        weaponType = "Machine Gun";
        minRange = 10f;
        maxRange = 15f;
        ShotTimer = 1f;
        Ammo = 45;

        damage = 4;

    }


    public override void Fire()
    {
        //for(int i = 0; i < 10; i++)
        //{


            foreach (GameObject bullet in bullets)
            {
                if (!bullet.activeInHierarchy)
                {
                    bullet.SetActive(true);
                    bullet.GetComponent<BulletController>().damage = damage;
                    bullet.transform.position = transform.position;
                    //bullet.transform.rotation = transform.rotation;
                    break;
                }
            }

        
        //}
    }
}
