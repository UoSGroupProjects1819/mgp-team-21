using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{


    public static List<BaseWeapon> baseWeapons = new List<BaseWeapon>();

    void Start() 
    {
        baseWeapons.Clear();
        Pistol pistol = gameObject.AddComponent<Pistol>();
        pistol.SetupWeapon();
        baseWeapons.Add(pistol);
        if (Blackboard.HasGlobalKey("hasRevolver"))
        {
            Revolver revolver = gameObject.AddComponent<Revolver>();
            revolver.SetupWeapon();
            baseWeapons.Add(revolver);
        }
        if (Blackboard.HasGlobalKey("hasShotgun"))
        {
            Shotgun shotgun = gameObject.AddComponent<Shotgun>();
            shotgun.SetupWeapon();
            baseWeapons.Add(shotgun);
        }
        if (Blackboard.HasGlobalKey("hasBARifle"))
        {
            Rifle rifle = gameObject.AddComponent<Rifle>();
            rifle.SetupWeapon();
            baseWeapons.Add(rifle);
        }
        if (Blackboard.HasGlobalKey("hasMachineGun"))
        {
            MachineGun machineGun = gameObject.AddComponent<MachineGun>();
            machineGun.SetupWeapon();
            baseWeapons.Add(machineGun);
        }
    }

    public BaseWeapon SwapWeapon()
    {
        if (baseWeapons.Count == 0) //Create starting weapons
        {
            Pistol pistol = gameObject.AddComponent<Pistol>();
            pistol.SetupWeapon();
            baseWeapons.Add(pistol);
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
            Blackboard.SetGlobalValue("hasRevolver", true);
        }
        else if (weapon == WeaponPickup.WeaponType.Shotgun)
        {
            Shotgun shotgun = gameObject.AddComponent<Shotgun>();
            shotgun.SetupWeapon();
            baseWeapons.Add(shotgun);
            Blackboard.SetGlobalValue("hasShotgun", true);
        }
        else if (weapon == WeaponPickup.WeaponType.BoltActionRifle)
        {
            Rifle rifle = gameObject.AddComponent<Rifle>();
            rifle.SetupWeapon();
            baseWeapons.Add(rifle);
            Blackboard.SetGlobalValue("hasBARifle", true);
        }
        else if (weapon == WeaponPickup.WeaponType.MachineGun)
        {
            MachineGun machineGun = gameObject.AddComponent<MachineGun>();
            machineGun.SetupWeapon();
            baseWeapons.Add(machineGun);
            Blackboard.SetGlobalValue("hasMachineGun", true);
        }
    }
}
