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
}
