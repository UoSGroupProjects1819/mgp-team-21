using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    float timeSinceShot = 0f;
    public float ShotTimer = 5f;
    public GameObject bullet;
    public int Ammo = 10;
    public BaseWeapon weapon;

    void Start() {
        weapon = GetComponent<WeaponSwitching>().SwapWeapon();
        BaseWeapon.CreateBullets(bullet);
        ShotTimer = weapon.ShotTimer;
        Ammo = weapon.Ammo;

        //for (int i = 0; i < bullets.Length; i++)
        //{
        //    bullets[i] = Instantiate(bullet);
        //}
        //foreach (GameObject bullet in bullets)
        //{
        //    bullet.SetActive(false);
        //}
	}

	//Creates bullets, Decrease ammo when shot
	void Update () {
        timeSinceShot += Time.deltaTime;

        if ((timeSinceShot >= ShotTimer) && (Ammo > 0))
        {
            weapon.Fire();
            Ammo--;
            timeSinceShot = 0f;
        }
        if (Ammo <= 0)
        {
            weapon = GetComponent<WeaponSwitching>().SwapWeapon();
            Ammo = weapon.Ammo;
            ShotTimer = weapon.ShotTimer;
        }
	}
}
