using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    float time = 0f;
    public float bulletSpeed = 1f;
    public int damage;
    Vector2 direction = new Vector2(0, 0);
    Quaternion rot = new Quaternion(0, 0, 0, 1);

    void OnEnable()
    {
        time = 0f;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));

        direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;

        ////float x = mousePosition.x - transform.position.x;
        ////float y = mousePosition.y - transform.position.y;

        ////rot = new Quaternion(0, 0, Mathf.Tan(y / x), 1);

        ////rot = Quaternion.LookRotation(new Vector3(x, y, 0));

        //Vector3 mousePosition = Input.mousePosition;
        //Vector3 bulletPosition = Camera.main.WorldToScreenPoint(transform.position);

        //float x = mousePosition.x - bulletPosition.x;
        //float y = mousePosition.y - bulletPosition.y;

        //rot = new Quaternion(0, 0, Mathf.Tan(y / x), 1);

        //Debug.Log(rot);
    }

    void Update () {
        transform.Translate(0 , bulletSpeed, 0);
        //transform.up = direction;
        //transform.rotation = rot;

        time += Time.deltaTime;
        if (time >= 30f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    //void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bullet Collision:" + collision.gameObject.name);
        if(!collision.gameObject.CompareTag("Player"))
        gameObject.SetActive(false);
    }
}
