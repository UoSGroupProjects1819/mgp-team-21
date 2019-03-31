using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{


    public static List<BaseWeapon> baseWeapons = new List<BaseWeapon>();

    void Start()
    {

    }


    public BaseWeapon SwapWeapon()
    {
        if (baseWeapons.Count == 0) //Create starting weapons
        {
            Pistol pistol = gameObject.AddComponent<Pistol>();
            pistol.SetupWeapon();
            baseWeapons.Add(pistol);

            //For scene changes, might be worth setting a global blackboard boolean and pulling from that each weapon that's been added
            //e.g. if (Blackboard.GetGlobalBool("hasRevolver")) baseWeapons.Add(revolver);
        }
        int number = Random.Range(0, baseWeapons.Count);
        Debug.Log(number);
        return baseWeapons[number];
    }

    public void AddWeapon(WeaponPickup.WeaponType weapon)
    {
        if (weapon == WeaponPickup.WeaponType.Revolver)
        {
            Revolver revolver = gameObject.AddComponent<Revolver>();
            revolver.SetupWeapon();
            baseWeapons.Add(revolver);
        }
        else if (weapon == WeaponPickup.WeaponType.Shotgun)
        {
            Shotgun shotgun = gameObject.AddComponent<Shotgun>();
            shotgun.SetupWeapon();
            baseWeapons.Add(shotgun);
        }
        else if (weapon == WeaponPickup.WeaponType.BoltActionRifle)
        {
            Rifle rifle = gameObject.AddComponent<Rifle>();
            rifle.SetupWeapon();
            baseWeapons.Add(rifle);
        }
        else if (weapon == WeaponPickup.WeaponType.MachineGun)
        {
            MachineGun machineGun = gameObject.AddComponent<MachineGun>();
            machineGun.SetupWeapon();
            baseWeapons.Add(machineGun);
        }
    }
}
