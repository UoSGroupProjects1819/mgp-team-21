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
        ShotTimer = 2f;
        Ammo = 8;

        damage = 10;
    }
}
