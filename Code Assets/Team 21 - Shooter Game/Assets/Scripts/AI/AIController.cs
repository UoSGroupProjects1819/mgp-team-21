using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    Behaviour BT;
    public BaseWeapon weapon;

    void Start () {
        try //first enemy spawned will need to create dictionary entry for EnemyCount so the GetInt will fail, 
        //figured since this is the only place a failed get value should be acceptable I'd just leave the single try catch here rather than add 8+ try catches to the blackboard
        {
            Blackboard.SetGlobalValue("EnemyCount", Blackboard.GetGlobalInt("EnemyCount") + 1);
        }
        catch
        {
            Blackboard.SetGlobalValue("EnemyCount", 1);
        }
        weapon = gameObject.AddComponent<Pistol>();
        weapon.SetupWeapon();
        GameObject go = gameObject;
        BT   = InitTree(go);
        gameObject.GetComponent<Blackboard>().SetValue("Health", 10f);
	}
	
	void FixedUpdate () {
        BT.Tick();
	}

    Behaviour InitTree(GameObject go)
    {
        IsAlive isAlive = new IsAlive(go); //Ensures character is alive before attempting to run any behaviours
        Selector engagement = new Selector(go);
        Shoot shooting = new Shoot(go);
        Sequencer movement = new Sequencer(go);
        FindPlayer find = new FindPlayer(go); //Checks how far away the player is and sets them as a target if nearby
        MoveToTarget move = new MoveToTarget(go); //Moves the character towards the target

        movement.AddChild(find);
        movement.AddChild(move);

        engagement.AddChild(shooting);
        engagement.AddChild(movement);

        isAlive.AddChild(engagement);
        return isAlive;
    }

    private void OnDisable()
    {
        if (!Blackboard.HasGlobalKey("Revolver") && !PickupController.dropRevolver)
        {
            if (Random.Range(0.0f, 1.0f) <= 1.0f / Blackboard.GetGlobalInt("EnemyCount"))
            {
                foreach (GameObject pickup in PickupController.weapons)
                {
                    if (!pickup.activeInHierarchy)
                    {
                        PickupController.dropRevolver = true;
                        pickup.GetComponent<WeaponPickup>().Weapon = WeaponPickup.WeaponType.Revolver;
                        pickup.transform.position = transform.position;
                        pickup.SetActive(true);
                        break;
                    }
                }
            }
        }
    }
}
