using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MachineGun : BaseWeapon
{



    // Use this for initialization
    public override void SetupWeapon()
    {
        weaponType = "Machine Gun";
        minRange = 10f;
        maxRange = 15f;
        ShotTimer = 0.1f;
        Ammo = 45;

        damage = 4;

    }

    //public override void Fire()
    //{
    //    float time = 0.0f;
    //    int shots = 0;
    //    while (shots < 5)
    //    {
    //        time += Time.deltaTime;
    //        if (time >= 0.5f)
    //        {
    //            foreach (GameObject bullet in bullets)
    //            {
    //                if (!bullet.activeInHierarchy)
    //                {
    //                    bullet.transform.position = transform.position;
    //                    bullet.SetActive(true);
    //                    bullet.GetComponent<BulletController>().damage = damage;
    //                    break;
    //                }
    //            }
    //            time = 0.0f;
    //            shots++;
    //        }
    //    }
    //}
}
