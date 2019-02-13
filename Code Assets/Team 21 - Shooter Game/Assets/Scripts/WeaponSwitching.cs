using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour {

    public float Ammo = 10f;
    public static List <BaseWeapon> baseWeapons = new List<BaseWeapon>();
    

    



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        NextWeapon();
	}

    void NextWeapon()
    {
        Ammo -= Time.deltaTime;

        if(Ammo < 0f)
        {
            var number = Random.Range(0, baseWeapons.Count);
            
        }
    }
}
