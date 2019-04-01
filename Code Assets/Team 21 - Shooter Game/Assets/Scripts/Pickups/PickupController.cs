using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

    public static GameObject[] weapons = new GameObject[5];
    public GameObject weaponPickup;
    public static bool dropRevolver = false;
    public static bool dropShotgun = false;
    public static bool dropBARifle = false;
    public static bool dropMachineGun = false;
	
	void Start ()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i] = Instantiate(weaponPickup);
            weapons[i].SetActive(false);
        }
	}
}
