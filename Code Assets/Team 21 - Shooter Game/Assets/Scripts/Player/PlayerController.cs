using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed = 5.5f;
    public float Health = 10f;

    void Start ()
    {
        gameObject.GetComponent<Blackboard>().SetValue("Health", Health); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
        LookAtMouse();
        
    }

    void Movement()
    {

        transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed, transform.position.y + Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed, transform.position.z);
    }

    void LookAtMouse()
    {
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Vector2 direction = new Vector2(
        //    mousePosition.x - transform.position.x,
        //    mousePosition.y - transform.position.y
        //);

        //transform.up = direction;

    }

}
