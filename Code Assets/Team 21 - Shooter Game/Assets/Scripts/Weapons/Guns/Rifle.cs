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
}
