using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour {

	public enum WeaponType
    {
        Pistol,
        Revolver,
        Shotgun,
        BoltActionRifle, 
        MachineGun
    };

    public WeaponType Weapon = WeaponType.Pistol;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<WeaponSwitching>().AddWeapon(Weapon);
            gameObject.SetActive(false);
        }
    }
}
