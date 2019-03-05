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
        if (baseWeapons.Count == 0)
        {
            Shotgun shotgun = gameObject.AddComponent<Shotgun>();
            shotgun.SetupWeapon();
            baseWeapons.Add(shotgun);

            Rifle rifle = gameObject.AddComponent<Rifle>();
            rifle.SetupWeapon();
            baseWeapons.Add(rifle);

            Revolver revolver = gameObject.AddComponent<Revolver>();
            revolver.SetupWeapon();
            baseWeapons.Add(revolver);

            MachineGun machineGun = gameObject.AddComponent<MachineGun>();
            machineGun.SetupWeapon();
            baseWeapons.Add(machineGun);
        }
        int number = Random.Range(0, baseWeapons.Count);
        Debug.Log(number);
        return baseWeapons[number];
    }
}
