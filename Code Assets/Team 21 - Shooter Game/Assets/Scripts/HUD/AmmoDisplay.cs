using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoDisplay : MonoBehaviour {

    public TextMeshProUGUI ammo;
    public GameObject Player;



    // Use this for initialization
    void Start()
    { 
        Player = Blackboard.GetGlobalGameObject("Player");

	}
	
	// Update is called once per frame
	void Update ()
    {
        ammo.text = Player.GetComponent<PlayerShooting>().weapon.weaponType.ToString() + " ";
        ammo.text += Player.GetComponent<PlayerShooting>().Ammo.ToString();

	}
}
