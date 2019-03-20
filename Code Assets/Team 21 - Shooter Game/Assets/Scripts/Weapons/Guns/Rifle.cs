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
        ShotTimer = 5f;
        Ammo = 5;

        damage = 10;
    }
}
