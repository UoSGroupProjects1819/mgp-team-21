using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    public float followDistance = 10f;
    float distanceX = 0f;
    float distanceY = 0f;
    public float cameraSpeed = 5f;
    

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
    }   
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);

        distanceX = Player.transform.position.x - transform.position.x;
        distanceY = Player.transform.position.y - transform.position.y;

        float distance = Mathf.Sqrt(Mathf.Pow(distanceX, 2) + Mathf.Pow(distanceY, 2));
        Debug.Log(distanceX + ", " + distanceY + ", " + distance);

        if (distance > followDistance)
        {
            transform.position = new Vector3(transform.position.x + distanceX * Time.deltaTime, transform.position.y + distanceY * Time.deltaTime, transform.position.z);
        }
    }
}
